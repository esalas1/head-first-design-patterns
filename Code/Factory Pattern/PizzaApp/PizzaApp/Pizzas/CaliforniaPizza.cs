using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public class CaliforniaPizza : Pizza
    {
        public CaliforniaPizza(string extraToppings)
        {
            name = "California Pizza";
            dough = "Thin Crust";
            sauce = "Pesto Sauce";

            toppings.Add(extraToppings);
        }
    }
}
