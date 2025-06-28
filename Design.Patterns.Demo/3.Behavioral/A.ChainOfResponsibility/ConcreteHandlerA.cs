namespace Design.Patterns.Demo._3.Behavioral.A.ChainOfResponsibility
{
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
}
