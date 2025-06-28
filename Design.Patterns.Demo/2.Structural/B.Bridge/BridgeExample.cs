namespace Design.Patterns.Demo._2.Structural.B.Bridge
{
    public static class BridgeExample
    {
        public static void Run()
        {
            var vectorRenderer = new VectorRenderer();
            var rasterRenderer = new RasterRenderer();

            Shape circle = new Circle(vectorRenderer);
            circle.Draw();

            circle = new Circle(rasterRenderer);
            circle.Draw();
        }
    }
}
