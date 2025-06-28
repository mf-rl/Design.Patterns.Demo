namespace Design.Patterns.Demo._2.Structural
{
    public static class AdapterExample
    {
        public static void Run()
        {
            ITarget target = new Adapter();
            target.Request();
        }
    }
    public class Adapter : ITarget
    {
        private Adaptee _adaptee = new Adaptee();

        public void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest in Adaptee.");
        }
    }
    public interface ITarget
    {
        void Request();
    }
}
