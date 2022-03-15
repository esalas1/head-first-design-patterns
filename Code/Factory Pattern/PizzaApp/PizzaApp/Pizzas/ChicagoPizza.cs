using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public class ChicagoPizza : Pizza
    {
        PizzaIngredientFactory _ingredientFactory;
        public ChicagoPizza(PizzaIngredientFactory ingredientFactory)
        {
            this._ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing Chicago Pizza");
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
        }
    }
}
