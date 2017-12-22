namespace CoffeeDecoratorExample
{
    public class CoffeeConcreteComponent : ICoffeeComponent
    {
        public double GetCost() => 1;

        public string GetIngredients() => "Coffee";
    }
}
