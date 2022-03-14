using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string extraToppings)
        {
            Pizza pizza = new ChicagoPizza(extraToppings);

            return pizza;
        }
    }
}
