using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public class NewYorkPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza()
        {
            PizzaIngredientFactory _ingredientFactory = new NewYorkIngredientsFactory();
            Pizza nyPizza = new NewYorkPizza(_ingredientFactory);
            
            return nyPizza;
        }
    }
}
