namespace Design.Patterns.Demo._2.Structural.C.Composite
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name) { }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
        }
    }
}
