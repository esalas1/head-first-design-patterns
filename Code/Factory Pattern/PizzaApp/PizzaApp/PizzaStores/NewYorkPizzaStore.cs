using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public class NewYorkPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string extraToppings)
        {
            Pizza nyPizza = new NewYorkPizza(extraToppings);
            
            return nyPizza;
        }
    }
}
