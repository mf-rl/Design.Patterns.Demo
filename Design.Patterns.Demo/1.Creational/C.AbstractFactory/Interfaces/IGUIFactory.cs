namespace Design.Patterns.Demo._1.Creational.C.AbstractFactory.Interfaces
{
    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
