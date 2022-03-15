using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public class NewYorkIngredientsFactory : PizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            Console.WriteLine("Creating Thin Crust Dough.");
            Dough dough = new ThinCrustDough();
            return dough;
        }

        public Sauce CreateSauce()
        {
            Console.WriteLine("Creating marinara Sauce.");
            Sauce sauce = new MarinaraSauce();
            return sauce;
        }

        public Cheese CreateCheese()
        {
            Console.WriteLine("Creating Parmesan Cheese.");
            Cheese cheese = new ParmesanCheese();
            return cheese;
        }
    }
}
