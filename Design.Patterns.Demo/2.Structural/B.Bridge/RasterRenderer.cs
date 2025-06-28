namespace Design.Patterns.Demo._2.Structural.B.Bridge
{
    public class RasterRenderer : IRenderer
    {
        public void Render(string shape)
        {
            Console.WriteLine($"Drawing {shape} as pixels.");
        }
    }
}
