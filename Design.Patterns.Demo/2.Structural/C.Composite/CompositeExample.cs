namespace Design.Patterns.Demo._2.Structural.C.Composite
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
}
