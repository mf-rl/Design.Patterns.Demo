namespace Design.Patterns.Demo._2.Structural.A.Adapter
{
    public class Adapter : ITarget
    {
        private Adaptee _adaptee = new Adaptee();

        public void Request()
        {
            _adaptee.SpecificRequest();
        }
    }

}
