namespace Design.Patterns.Demo._2.Structural
{
    public static class FlyweightExample
    {
        public static void Run()
        {
            var factory = new ShapeFactory();

            var redCircle = factory.GetCircle("Red");
            redCircle.Draw(10, 20);

            var blueCircle = factory.GetCircle("Blue");
            blueCircle.Draw(15, 25);

            var anotherRedCircle = factory.GetCircle("Red");
            anotherRedCircle.Draw(30, 40);

            Console.WriteLine("Note: Same object used for red circles.");
        }
    }
    public class ShapeFactory
    {
        private Dictionary<string, IShape> _shapes = new Dictionary<string, IShape>();

        public IShape GetCircle(string color)
        {
            if (!_shapes.ContainsKey(color))
            {
                _shapes[color] = new Circle(color);
            }
            return _shapes[color];
        }
    }
    public class Circle : IShape
    {
        private readonly string _color;

        public Circle(string color)
        {
            _color = color;
        }

        public void Draw(int x, int y)
        {
            Console.WriteLine($"Drawing {_color} circle at ({x}, {y})");
        }
    }
    public interface IShape
    {
        void Draw(int x, int y);
    }
}
