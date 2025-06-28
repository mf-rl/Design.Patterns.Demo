namespace Design.Patterns.Demo._1.Creational
{
    public static class FactoryMethodExample
    {
        public static void Run()
        {
            Creator creator = new ConcreteCreatorA();
            var productA = creator.FactoryMethod();
            productA.Operation();

            creator = new ConcreteCreatorB();
            var productB = creator.FactoryMethod();
            productB.Operation();
        }
    }
    public abstract class Creator
    {
        public abstract Product FactoryMethod();
    }
    public abstract class Product
    {
        public abstract void Operation();
    }
    public class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod() => new ConcreteProductA();
    }
    public class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod() => new ConcreteProductB();
    }
    public class ConcreteProductA : Product
    {
        public override void Operation() => Console.WriteLine("ConcreteProductA Operation executed.");
    }
    public class ConcreteProductB : Product
    {
        public override void Operation() => Console.WriteLine("ConcreteProductB Operation executed.");
    }
}
