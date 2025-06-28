namespace Design.Patterns.Demo._3.Behavioral
{
    public static class MementoExample
    {
        public static void Run()
        {
            var originator = new Originator();
            var caretaker = new Caretaker();

            originator.State = "State #1";
            caretaker.AddMemento(originator.SaveState());

            originator.State = "State #2";
            caretaker.AddMemento(originator.SaveState());

            originator.State = "State #3";
            Console.WriteLine($"Current State: {originator.State}");

            originator.RestoreState(caretaker.GetMemento(0));
            Console.WriteLine($"Restored to: {originator.State}");
        }
    }
    public class Originator
    {
        public string State { get; set; }

        public Memento SaveState()
        {
            return new Memento(State);
        }

        public void RestoreState(Memento memento)
        {
            State = memento.State;
        }
    }

    public class Caretaker
    {
        private List<Memento> _mementos = new List<Memento>();

        public void AddMemento(Memento memento)
        {
            _mementos.Add(memento);
        }

        public Memento GetMemento(int index)
        {
            return _mementos[index];
        }
    }
    public class Memento
    {
        public string State { get; private set; }

        public Memento(string state)
        {
            State = state;
        }
    }
}
