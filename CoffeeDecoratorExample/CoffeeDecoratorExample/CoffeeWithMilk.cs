namespace CoffeeDecoratorExample
{
    public class CoffeeWithMilkConcreteDecorator : CoffeeDecorator
    {
        public CoffeeWithMilkConcreteDecorator(ICoffeeComponent coffee) : base(coffee)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.5;
        }

        public override string GetIngredients()
        {
            return base.GetIngredients() + ", Milk";
        }
    }
}
