namespace Design.Patterns.Demo._2.Structural
{
    public static class FacadeExample
    {
        public static void Run()
        {
            var facade = new Facade();
            facade.Operation();
        }
    }
    public class Facade
    {
        private readonly SubsystemA _subsystemA;
        private readonly SubsystemB _subsystemB;
        private readonly SubsystemC _subsystemC;

        public Facade()
        {
            _subsystemA = new SubsystemA();
            _subsystemB = new SubsystemB();
            _subsystemC = new SubsystemC();
        }

        public void Operation()
        {
            Console.WriteLine("Facade initiates operations:");
            _subsystemA.OperationA();
            _subsystemB.OperationB();
            _subsystemC.OperationC();
        }
    }
    public class SubsystemA
    {
        public void OperationA()
        {
            Console.WriteLine("Subsystem A: Operation A executed.");
        }
    }
    public class SubsystemB
    {
        public void OperationB()
        {
            Console.WriteLine("Subsystem B: Operation B executed.");
        }
    }
    public class SubsystemC
    {
        public void OperationC()
        {
            Console.WriteLine("Subsystem C: Operation C executed.");
        }
    }
}
