using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public class CaliforniaPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza()
        {
            PizzaIngredientFactory ingredientfactory = new CaliforniaPizzaIngredientFactory();
            Pizza pizza = new CaliforniaPizza(ingredientfactory);

            return pizza;
        }
    }
}
