namespace Design.Patterns.Demo._3.Behavioral
{
    public static class TemplateMethodExample
    {
        public static void Run()
        {
            AbstractClass a = new ConcreteClassA();
            a.TemplateMethod();

            AbstractClass b = new ConcreteClassB();
            b.TemplateMethod();
        }
    }
    public class ConcreteClassA : AbstractClass
    {
        protected override void StepOne()
        {
            Console.WriteLine("ConcreteClassA: Step One");
        }

        protected override void StepTwo()
        {
            Console.WriteLine("ConcreteClassA: Step Two");
        }
    }

    public class ConcreteClassB : AbstractClass
    {
        protected override void StepOne()
        {
            Console.WriteLine("ConcreteClassB: Step One");
        }

        protected override void StepTwo()
        {
            Console.WriteLine("ConcreteClassB: Step Two");
        }

        protected override void StepThree()
        {
            Console.WriteLine("ConcreteClassB: Custom Step Three");
        }
    }
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            StepOne();
            StepTwo();
            StepThree();
        }

        protected abstract void StepOne();
        protected abstract void StepTwo();
        protected virtual void StepThree()
        {
            Console.WriteLine("Default implementation of Step Three.");
        }
    }
}
