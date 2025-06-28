namespace Design.Patterns.Demo._2.Structural.C.Composite
{
    public abstract class Component
    {
        public string Name { get; set; }
        public Component(string name) { Name = name; }
        public abstract void Display(int depth);
    }
}
