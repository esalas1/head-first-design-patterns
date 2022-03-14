using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public class CaliforniaPizzaStore : PizzaStore
    {
        override public Pizza CreatePizza(string extraToppings)
        {
            Pizza pizza = new CaliforniaPizza(extraToppings);

            return pizza;
        }
    }
}
