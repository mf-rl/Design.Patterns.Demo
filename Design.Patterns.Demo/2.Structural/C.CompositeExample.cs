namespace Design.Patterns.Demo._2.Structural
{
    public static class CompositeExample
    {
        public static void Run()
        {
            var root = new Composite("Root");

            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            var subComposite = new Composite("Sub-Composite");
            subComposite.Add(new Leaf("Leaf C"));
            subComposite.Add(new Leaf("Leaf D"));

            root.Add(subComposite);

            root.Display(1);
        }
    }
    public class Composite : Component
    {
        private List<Component> _children = new List<Component>();

        public Composite(string name) : base(name) { }

        public void Add(Component component)
        {
            _children.Add(component);
        }

        public void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);

            foreach (var component in _children)
            {
                component.Display(depth + 2);
            }
        }
    }
    public class Leaf : Component
    {
        public Leaf(string name) : base(name) { }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
        }
    }
    public abstract class Component
    {
        public string Name { get; set; }
        public Component(string name) { Name = name; }
        public abstract void Display(int depth);
    }
}
