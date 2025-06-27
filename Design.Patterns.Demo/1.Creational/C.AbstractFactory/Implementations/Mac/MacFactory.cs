using Design.Patterns.Demo._1.Creational.C.AbstractFactory.Interfaces;

namespace Design.Patterns.Demo._1.Creational.C.AbstractFactory.Implementations.Mac
{
    public class MacFactory : IGUIFactory
    {
        public IButton CreateButton() => new MacButton();
        public ICheckbox CreateCheckbox() => new MacCheckbox();
    }
}
