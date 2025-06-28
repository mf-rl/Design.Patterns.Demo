namespace Design.Patterns.Demo._2.Structural.E.Facade
{
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
}
