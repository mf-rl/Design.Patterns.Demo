namespace Design.Patterns.Demo._1.Creational.E.Prototype
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override Shape Clone()
        {
            return new Rectangle { X = this.X, Y = this.Y, Width = this.Width, Height = this.Height };
        }
    }
}
