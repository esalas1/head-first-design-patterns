using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public class NewYorkPizza : Pizza
    {
        public NewYorkPizza(string extraToppings)
        {
            name = "New York Styyle Pizza";
            dough = "Thin Crust";
            sauce = "Marinara Sauce";

            toppings.Add(extraToppings);
        }
    }
}
