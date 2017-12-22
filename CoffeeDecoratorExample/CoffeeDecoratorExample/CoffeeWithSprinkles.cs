namespace CoffeeDecoratorExample
{
    public class CoffeeWithSprinklesConcreteDecorator : CoffeeDecorator
    {
        public CoffeeWithSprinklesConcreteDecorator(ICoffeeComponent coffee) : base(coffee)
        {
        }


        public override double GetCost()
        {
            return base.GetCost() + 0.2;
        }

        public override string GetIngredients()
        {
            return base.GetIngredients() + ", Sprinkles";
        }
    }
}
