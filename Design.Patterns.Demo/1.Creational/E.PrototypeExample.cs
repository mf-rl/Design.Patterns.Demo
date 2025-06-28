namespace Design.Patterns.Demo._1.Creational
{
    public static class PrototypeExample
    {
        public static void Run()
        {
            var circle = new Circle { X = 10, Y = 20, Radius = 15 };
            var clonedCircle = circle.Clone();
            Console.WriteLine($"Cloned Circle: X={clonedCircle.X}, Y={clonedCircle.Y}, Radius={(clonedCircle as Circle).Radius}");

            var rectangle = new Rectangle { X = 5, Y = 5, Width = 30, Height = 40 };
            var clonedRectangle = rectangle.Clone();
            Console.WriteLine($"Cloned Rectangle: X={clonedRectangle.X}, Y={clonedRectangle.Y}, Width={(clonedRectangle as Rectangle).Width}, Height={(clonedRectangle as Rectangle).Height}");
        }
    }
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public override Shape Clone()
        {
            return new Circle { X = this.X, Y = this.Y, Radius = this.Radius };
        }
    }
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override Shape Clone()
        {
            return new Rectangle { X = this.X, Y = this.Y, Width = this.Width, Height = this.Height };
        }
    }
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public abstract Shape Clone();
    }
}
