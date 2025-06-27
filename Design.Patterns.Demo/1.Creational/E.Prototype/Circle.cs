namespace Design.Patterns.Demo._1.Creational.E.Prototype
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public override Shape Clone()
        {
            return new Circle { X = this.X, Y = this.Y, Radius = this.Radius };
        }
    }
}
