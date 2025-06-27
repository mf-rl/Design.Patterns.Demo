using Design.Patterns.Demo._1.Creational.C.AbstractFactory.Interfaces;

namespace Design.Patterns.Demo._1.Creational.C.AbstractFactory.Implementations.Windows
{
    public class WindowsCheckbox : ICheckbox
    {
        public void Render() => Console.WriteLine("Rendering Windows Checkbox.");
    }
}
