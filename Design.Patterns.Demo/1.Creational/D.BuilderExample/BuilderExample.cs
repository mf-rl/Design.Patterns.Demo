namespace Design.Patterns.Demo._1.Creational
{
    public static class BuilderExample
    {
        public static void Run()
        {
            var vegBuilder = new VegMealBuilder();
            var director = new MealDirector(vegBuilder);
            var vegMeal = director.Construct();
            vegMeal.Display();

            var nonVegBuilder = new NonVegMealBuilder();
            director = new MealDirector(nonVegBuilder);
            var nonVegMeal = director.Construct();
            nonVegMeal.Display();
        }
    }
    public class NonVegMealBuilder : IMealBuilder
    {
        private Meal _meal = new();

        public void BuildMainDish() => _meal.MainDish = "Chicken Burger";
        public void BuildSideDish() => _meal.SideDish = "Fries";
        public void BuildDrink() => _meal.Drink = "Cola";

        public Meal GetMeal() => _meal;
    }
    public class VegMealBuilder : IMealBuilder
    {
        private Meal _meal = new();

        public void BuildMainDish() => _meal.MainDish = "Veggie Burger";
        public void BuildSideDish() => _meal.SideDish = "Salad";
        public void BuildDrink() => _meal.Drink = "Orange Juice";

        public Meal GetMeal() => _meal;
    }
    public interface IMealBuilder
    {
        void BuildMainDish();
        void BuildSideDish();
        void BuildDrink();
        Meal GetMeal();
    }
    public class MealDirector
    {
        private IMealBuilder _builder;

        public MealDirector(IMealBuilder builder)
        {
            _builder = builder;
        }

        public Meal Construct()
        {
            _builder.BuildMainDish();
            _builder.BuildSideDish();
            _builder.BuildDrink();
            return _builder.GetMeal();
        }
    }
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
