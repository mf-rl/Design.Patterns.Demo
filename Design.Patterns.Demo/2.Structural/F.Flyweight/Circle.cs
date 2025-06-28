namespace Design.Patterns.Demo._2.Structural.F.Flyweight
{
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
}
