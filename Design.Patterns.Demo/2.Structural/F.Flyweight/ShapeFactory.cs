namespace Design.Patterns.Demo._2.Structural.F.Flyweight
{
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

}
