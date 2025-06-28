namespace Design.Patterns.Demo._3.Behavioral
{
    public static class IteratorExample
    {
        public static void Run()
        {
            var collection = new NameCollection();
            collection.AddName("Alice");
            collection.AddName("Bob");
            collection.AddName("Charlie");

            var iterator = collection.CreateIterator();

            while (iterator.HasNext())
            {
                Console.WriteLine($"Name: {iterator.Next()}");
            }
        }
    }

    public class NameCollection : IAggregate<string>
    {
        private List<string> _names = new List<string>();

        public void AddName(string name)
        {
            _names.Add(name);
        }

        public IIterator<string> CreateIterator()
        {
            return new NameIterator(_names);
        }
    }

    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }

    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }

    public class NameIterator : IIterator<string>
    {
        private List<string> _names;
        private int _position = 0;

        public NameIterator(List<string> names)
        {
            _names = names;
        }

        public bool HasNext()
        {
            return _position < _names.Count;
        }

        public string Next()
        {
            return _names[_position++];
        }
    }
}
