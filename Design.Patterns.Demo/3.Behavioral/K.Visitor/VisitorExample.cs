namespace Design.Patterns.Demo._3.Behavioral
{
    public static class VisitorExample
    {
        public static void Run()
        {
            var elements = new IElement[] { new ElementA(), new ElementB() };
            var visitor = new ConcreteVisitor();

            foreach (var element in elements)
            {
                element.Accept(visitor);
            }
        }
    }
    public class ConcreteVisitor : IVisitor
    {
        public void Visit(ElementA element)
        {
            Console.WriteLine("Visiting ElementA");
            element.OperationA();
        }

        public void Visit(ElementB element)
        {
            Console.WriteLine("Visiting ElementB");
            element.OperationB();
        }
    }
    public class ElementA : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void OperationA()
        {
            Console.WriteLine("ElementA OperationA");
        }
    }

    public class ElementB : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void OperationB()
        {
            Console.WriteLine("ElementB OperationB");
        }
    }
    public interface IVisitor
    {
        void Visit(ElementA element);
        void Visit(ElementB element);
    }

    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
