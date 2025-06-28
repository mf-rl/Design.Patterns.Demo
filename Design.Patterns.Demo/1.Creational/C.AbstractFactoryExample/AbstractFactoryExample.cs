namespace Design.Patterns.Demo._1.Creational
{
    public static class AbstractFactoryExample
    {
        public static void Run()
        {
            IGUIFactory factory = new WindowsFactory();
            var button = factory.CreateButton();
            var checkbox = factory.CreateCheckbox();
            button.Render();
            checkbox.Render();

            factory = new MacFactory();
            button = factory.CreateButton();
            checkbox = factory.CreateCheckbox();
            button.Render();
            checkbox.Render();
        }
    }
    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
    public interface IButton { void Render(); }
    public interface ICheckbox { void Render(); }
    public class WindowsFactory : IGUIFactory
    {
        public IButton CreateButton() => new WindowsButton();
        public ICheckbox CreateCheckbox() => new WindowsCheckbox();
    }
    public class MacFactory : IGUIFactory
    {
        public IButton CreateButton() => new MacButton();
        public ICheckbox CreateCheckbox() => new MacCheckbox();
    }
    public class WindowsButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering Windows Button.");
    }
    public class MacButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering Mac Button.");
    }
    public class WindowsCheckbox : ICheckbox
    {
        public void Render() => Console.WriteLine("Rendering Windows Checkbox.");
    }
    public class MacCheckbox : ICheckbox
    {
        public void Render() => Console.WriteLine("Rendering Mac Checkbox.");
    }
}
