﻿namespace Design.Patterns.Demo._1.Creational
{
    public static class SingletonExample
    {
        public static void Run()
        {
            var logger = Logger.Instance;
            logger.Log("Singleton Pattern Example Executed.");
        }
    }
    public class Logger
    {
        private static Logger? _instance;
        private static readonly object _lock = new();

        private Logger() { }

        public static Logger Instance
        {
            get
            {
                lock (_lock)
                {
                    return _instance ??= new Logger();
                }
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"[LOG]: {message}");
        }
    }
}
