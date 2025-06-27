namespace Design.Patterns.Demo._1.Creational.D.Builder
{
    public class Meal
    {
        public string? MainDish { get; set; }
        public string? SideDish { get; set; }
        public string? Drink { get; set; }

        public void Display()
        {
            Console.WriteLine($"Meal includes: {MainDish}, {SideDish}, {Drink}");
        }
    }
}
