using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza()
        {
            PizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();
            Pizza pizza = new ChicagoPizza(ingredientFactory);

            return pizza;
        }
    }
}
