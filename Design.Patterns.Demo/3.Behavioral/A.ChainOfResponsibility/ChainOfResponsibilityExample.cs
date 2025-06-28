namespace Design.Patterns.Demo._3.Behavioral.A.ChainOfResponsibility
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
}
