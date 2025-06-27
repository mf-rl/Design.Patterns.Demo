namespace Design.Patterns.Demo._1.Creational.B.FactoryMethod
{
    public class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod() => new ConcreteProductA();
    }
}
