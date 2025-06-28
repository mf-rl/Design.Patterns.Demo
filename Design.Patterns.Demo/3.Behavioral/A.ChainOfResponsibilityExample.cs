namespace Design.Patterns.Demo._3.Behavioral
{
    public static class ChainOfResponsibilityExample
    {
        public static void Run()
        {
            var handlerA = new ConcreteHandlerA();
            var handlerB = new ConcreteHandlerB();

            handlerA.SetNext(handlerB);

            handlerA.HandleRequest("TaskA");
            handlerA.HandleRequest("TaskB");
            handlerA.HandleRequest("TaskC");
        }
    }
    public class ConcreteHandlerA : Handler
    {
        public override void HandleRequest(string request)
        {
            if (request == "TaskA")
            {
                Console.WriteLine("ConcreteHandlerA handled the request.");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
            else
            {
                Console.WriteLine("No handler found for the request.");
            }
        }
    }
    public class ConcreteHandlerB : Handler
    {
        public override void HandleRequest(string request)
        {
            if (request == "TaskB")
            {
                Console.WriteLine("ConcreteHandlerB handled the request.");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
            else
            {
                Console.WriteLine("No handler found for the request.");
            }
        }
    }
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
