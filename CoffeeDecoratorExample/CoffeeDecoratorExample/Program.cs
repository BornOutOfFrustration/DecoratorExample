using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeDecoratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ICoffeeComponent c = new CoffeeConcreteComponent();
            Console.WriteLine($"Cost: {c.GetCost()}; Ingredients: {c.GetIngredients()}");

            c = new CoffeeWithMilkConcreteDecorator(c);
            Console.WriteLine($"Cost: {c.GetCost()}; Ingredients: {c.GetIngredients()}");

            c = new CoffeeWithSprinklesConcreteDecorator(c);
            Console.WriteLine($"Cost: {c.GetCost()}; Ingredients: {c.GetIngredients()}");
            // Console.ReadLine();
        }
    }
}
