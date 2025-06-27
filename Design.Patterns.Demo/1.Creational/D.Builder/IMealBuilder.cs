namespace Design.Patterns.Demo._1.Creational.D.Builder
{
    public interface IMealBuilder
    {
        void BuildMainDish();
        void BuildSideDish();
        void BuildDrink();
        Meal GetMeal();
    }
}
