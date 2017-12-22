namespace CoffeeDecoratorExample
{
    public abstract class CoffeeDecorator : ICoffeeComponent
    {
        protected readonly ICoffeeComponent DecoratedCoffee;

        public CoffeeDecorator(ICoffeeComponent coffee)
        {
            this.DecoratedCoffee = coffee;
        }

        public virtual double GetCost() { return this.DecoratedCoffee.GetCost(); }
        public virtual string GetIngredients() { return this.DecoratedCoffee.GetIngredients(); }
    }
}
