using Design.Patterns.Demo._1.Creational.C.AbstractFactory.Implementations.Mac;
using Design.Patterns.Demo._1.Creational.C.AbstractFactory.Implementations.Windows;
using Design.Patterns.Demo._1.Creational.C.AbstractFactory.Interfaces;

namespace Design.Patterns.Demo._1.Creational.C.AbstractFactory
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
}
