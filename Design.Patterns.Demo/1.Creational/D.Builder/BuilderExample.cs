namespace Design.Patterns.Demo._1.Creational.D.Builder
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
}
