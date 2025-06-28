namespace Design.Patterns.Demo._2.Structural.D.Decorator
{
    public class SMSNotifier : NotifierDecorator
    {
        public SMSNotifier(INotifier notifier) : base(notifier) { }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Sending SMS: {message}");
        }
    }
}
