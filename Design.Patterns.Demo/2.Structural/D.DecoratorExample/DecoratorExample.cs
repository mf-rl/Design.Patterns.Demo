namespace Design.Patterns.Demo._2.Structural
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
    public class EmailNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending Email: {message}");
        }
    }
    public class SMSNotifier : NotifierDecorator
    {
        public SMSNotifier(INotifier notifier) : base(notifier) { }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Sending SMS: {message}");
        }
    }
    public class FacebookNotifier : NotifierDecorator
    {
        public FacebookNotifier(INotifier notifier) : base(notifier) { }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Sending Facebook Message: {message}");
        }
    }
    public abstract class NotifierDecorator : INotifier
    {
        protected INotifier _wrappee;

        protected NotifierDecorator(INotifier notifier)
        {
            _wrappee = notifier;
        }

        public virtual void Send(string message)
        {
            _wrappee.Send(message);
        }
    }
    public interface INotifier
    {
        void Send(string message);
    }
}
