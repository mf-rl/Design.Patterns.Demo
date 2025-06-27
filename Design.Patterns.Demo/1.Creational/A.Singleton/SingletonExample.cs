namespace Design.Patterns.Demo._1.Creational.A.Singleton
{
    public static class SingletonExample
    {
        public static void Run()
        {
            var logger = Logger.Instance;
            logger.Log("Singleton Pattern Example Executed.");
        }
    }
}
