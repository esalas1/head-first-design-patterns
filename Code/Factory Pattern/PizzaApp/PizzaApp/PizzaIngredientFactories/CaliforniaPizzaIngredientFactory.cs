using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public class CaliforniaPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            Console.WriteLine("Creating Stuffed Crust Dough.");
            Dough dough = new StuffedCrustDough();
            return dough;
        }

        public Sauce CreateSauce()
        {
            Console.WriteLine("Creating Marinara Sauce.");
            Sauce sauce = new MarinaraSauce();
            return sauce;
        }

        public Cheese CreateCheese()
        {
            Console.WriteLine("Creating Mozzarella Cheese.");
            Cheese cheese = new MozzarellaCheese();
            return cheese;
        }
    }
}
