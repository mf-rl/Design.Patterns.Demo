namespace Design.Patterns.Demo._2.Structural.F.Flyweight
{
    public static class FlyweightExample
    {
        public static void Run()
        {
            var factory = new ShapeFactory();

            var redCircle = factory.GetCircle("Red");
            redCircle.Draw(10, 20);

            var blueCircle = factory.GetCircle("Blue");
            blueCircle.Draw(15, 25);

            var anotherRedCircle = factory.GetCircle("Red");
            anotherRedCircle.Draw(30, 40);

            Console.WriteLine("Note: Same object used for red circles.");
        }
    }
}
