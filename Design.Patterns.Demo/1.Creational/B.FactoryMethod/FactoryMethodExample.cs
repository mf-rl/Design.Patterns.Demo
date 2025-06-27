namespace Design.Patterns.Demo._1.Creational.B.FactoryMethod
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
}
