namespace Design.Patterns.Demo._2.Structural.D.Decorator
{
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
}
