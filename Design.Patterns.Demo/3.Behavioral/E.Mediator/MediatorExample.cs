namespace Design.Patterns.Demo._3.Behavioral
{
    public static class MediatorExample
    {
        public static void Run()
        {
            var mediator = new ConcreteMediator();

            var colleague1 = new ConcreteColleague1(mediator);
            var colleague2 = new ConcreteColleague2(mediator);

            mediator.Colleague1 = colleague1;
            mediator.Colleague2 = colleague2;

            colleague1.Send("Hello from Colleague 1");
            colleague2.Send("Hello from Colleague 2");
        }
    }
    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(IMediator mediator) : base(mediator) { }

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"Colleague1 received: {message}");
        }
    }
    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(IMediator mediator) : base(mediator) { }

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"Colleague2 received: {message}");
        }
    }

    public class ConcreteMediator : IMediator
    {
        public ConcreteColleague1 Colleague1 { get; set; }
        public ConcreteColleague2 Colleague2 { get; set; }

        public void Send(string message, Colleague colleague)
        {
            if (colleague == Colleague1)
            {
                Colleague2.Receive(message);
            }
            else
            {
                Colleague1.Receive(message);
            }
        }
    }
    public abstract class Colleague
    {
        protected IMediator _mediator;

        public Colleague(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
    public interface IMediator
    {
        void Send(string message, Colleague colleague);
    }

}
