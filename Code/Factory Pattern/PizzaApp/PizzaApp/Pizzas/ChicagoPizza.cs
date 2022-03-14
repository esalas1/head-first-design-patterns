using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public class ChicagoPizza : Pizza
    {
        public ChicagoPizza(string extraToppings)
        {
            name = "Chicago Style Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Red Tomato Sauce";

            toppings.Add(extraToppings);
        }
    }
}
