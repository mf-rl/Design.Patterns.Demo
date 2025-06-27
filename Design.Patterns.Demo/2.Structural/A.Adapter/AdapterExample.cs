namespace Design.Patterns.Demo._2.Structural.A.Adapter
{
    public static class AdapterExample
    {
        public static void Run()
        {
            ITarget target = new Adapter();
            target.Request();
        }
    }
}
