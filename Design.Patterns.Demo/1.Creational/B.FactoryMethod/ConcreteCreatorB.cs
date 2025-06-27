namespace Design.Patterns.Demo._1.Creational.B.FactoryMethod
{
    public class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod() => new ConcreteProductB();
    }
}
