using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public class NewYorkPizza : Pizza
    {
        PizzaIngredientFactory _ingredientFactory;
        public NewYorkPizza(PizzaIngredientFactory ingredientFactory)
        {
            this._ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing New York Pizza");
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
        }
    }
}
