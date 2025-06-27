using Design.Patterns.Demo._1.Creational.C.AbstractFactory.Interfaces;

namespace Design.Patterns.Demo._1.Creational.C.AbstractFactory.Implementations.Windows
{
    public class WindowsFactory : IGUIFactory
    {
        public IButton CreateButton() => new WindowsButton();
        public ICheckbox CreateCheckbox() => new WindowsCheckbox();
    }
}
