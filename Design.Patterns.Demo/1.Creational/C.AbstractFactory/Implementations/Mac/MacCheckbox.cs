using Design.Patterns.Demo._1.Creational.C.AbstractFactory.Interfaces;

namespace Design.Patterns.Demo._1.Creational.C.AbstractFactory.Implementations.Mac
{
    public class MacCheckbox : ICheckbox
    {
        public void Render() => Console.WriteLine("Rendering Mac Checkbox.");
    }
}
