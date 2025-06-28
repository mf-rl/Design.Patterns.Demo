namespace Design.Patterns.Demo._3.Behavioral.A.ChainOfResponsibility
{
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
}
