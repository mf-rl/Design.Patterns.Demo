namespace Design.Patterns.Demo._3.Behavioral
{
    public static class StateExample
    {
        public static void Run()
        {
            var context = new ExampleContext(new StateA());
            context.Request();
            context.Request();
        }
    }
    public class ExampleContext
    {
        private IState _state;

        public ExampleContext(IState state)
        {
            TransitionTo(state);
        }

        public void TransitionTo(IState state)
        {
            _state = state;
            Console.WriteLine($"Context: Transition to {state.GetType().Name}");
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }

    public class StateA : IState
    {
        public void Handle(ExampleContext context)
        {
            Console.WriteLine("StateA handles request.");
            context.TransitionTo(new StateB());
        }
    }

    public class StateB : IState
    {
        public void Handle(ExampleContext context)
        {
            Console.WriteLine("StateB handles request.");
            context.TransitionTo(new StateA());
        }
    }
    public interface IState
    {
        void Handle(ExampleContext context);
    }
}
