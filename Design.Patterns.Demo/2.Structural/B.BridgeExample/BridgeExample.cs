namespace Design.Patterns.Demo._2.Structural
{
    public static class BridgeExample
    {
        public static void Run()
        {
            var vectorRenderer = new VectorRenderer();
            var rasterRenderer = new RasterRenderer();

            Shape circle = new CircleShape(vectorRenderer);
            circle.Draw();

            circle = new CircleShape(rasterRenderer);
            circle.Draw();
        }
    }
    public class VectorRenderer : IRenderer
    {
        public void Render(string shape)
        {
            Console.WriteLine($"Drawing {shape} as lines.");
        }
    }
    public class RasterRenderer : IRenderer
    {
        public void Render(string shape)
        {
            Console.WriteLine($"Drawing {shape} as pixels.");
        }
    }
    public class CircleShape : Shape
    {
        public CircleShape(IRenderer renderer) : base(renderer) { }

        public override void Draw()
        {
            _renderer.Render("Circle");
        }
    }
    public abstract class Shape
    {
        protected IRenderer _renderer;

        protected Shape(IRenderer renderer)
        {
            _renderer = renderer;
        }

        public abstract void Draw();
    }
    public interface IRenderer
    {
        void Render(string shape);
    }
}
