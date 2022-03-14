using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string extraToppings)
        {
            Pizza pizza;
            pizza = CreatePizza(extraToppings);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Boxed();

            return pizza;
        }

        public abstract Pizza CreatePizza(string type);
    }
}
