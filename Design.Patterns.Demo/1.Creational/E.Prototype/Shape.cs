namespace Design.Patterns.Demo._1.Creational.E.Prototype
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public abstract Shape Clone();
    }
}
