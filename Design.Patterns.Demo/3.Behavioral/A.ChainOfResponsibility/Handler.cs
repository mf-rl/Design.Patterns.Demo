namespace Design.Patterns.Demo._3.Behavioral.A.ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler _nextHandler;

        public Handler SetNext(Handler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public abstract void HandleRequest(string request);
    }
}
