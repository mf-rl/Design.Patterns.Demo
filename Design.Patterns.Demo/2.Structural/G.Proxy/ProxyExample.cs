namespace Design.Patterns.Demo._2.Structural.G.Proxy
{
    public static class ProxyExample
    {
        public static void Run()
        {
            IImage image = new ProxyImage("test_image.jpg");

            // Image will be loaded and displayed
            image.Display();

            // Image will be displayed directly (no loading)
            image.Display();
        }
    }
}
