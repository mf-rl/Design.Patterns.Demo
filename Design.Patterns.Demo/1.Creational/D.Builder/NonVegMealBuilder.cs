namespace Design.Patterns.Demo._1.Creational.D.Builder
{
    public class NonVegMealBuilder : IMealBuilder
    {
        private Meal _meal = new();

        public void BuildMainDish() => _meal.MainDish = "Chicken Burger";
        public void BuildSideDish() => _meal.SideDish = "Fries";
        public void BuildDrink() => _meal.Drink = "Cola";

        public Meal GetMeal() => _meal;
    }
}
