namespace Design.Patterns.Demo._2.Structural.D.Decorator
{
    public static class DecoratorExample
    {
        public static void Run()
        {
            INotifier notifier = new EmailNotifier();
            notifier = new SMSNotifier(notifier);
            notifier = new FacebookNotifier(notifier);

            notifier.Send("Decorator Pattern Example Executed.");
        }
    }
}
