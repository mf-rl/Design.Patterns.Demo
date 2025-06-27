namespace Design.Patterns.Demo._1.Creational.D.Builder
{
    public class VegMealBuilder : IMealBuilder
    {
        private Meal _meal = new();

        public void BuildMainDish() => _meal.MainDish = "Veggie Burger";
        public void BuildSideDish() => _meal.SideDish = "Salad";
        public void BuildDrink() => _meal.Drink = "Orange Juice";

        public Meal GetMeal() => _meal;
    }
}
