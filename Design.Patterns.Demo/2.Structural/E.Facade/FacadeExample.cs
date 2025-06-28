namespace Design.Patterns.Demo._2.Structural.E.Facade
{
    public static class FacadeExample
    {
        public static void Run()
        {
            var facade = new Facade();
            facade.Operation();
        }
    }
}
