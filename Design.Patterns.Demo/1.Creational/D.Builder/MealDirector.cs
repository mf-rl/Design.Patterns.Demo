namespace Design.Patterns.Demo._1.Creational.D.Builder
{
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
}
