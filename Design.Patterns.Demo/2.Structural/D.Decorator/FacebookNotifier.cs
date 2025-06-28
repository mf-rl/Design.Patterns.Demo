namespace Design.Patterns.Demo._2.Structural.D.Decorator
{
    public class FacebookNotifier : NotifierDecorator
    {
        public FacebookNotifier(INotifier notifier) : base(notifier) { }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Sending Facebook Message: {message}");
        }
    }
}
