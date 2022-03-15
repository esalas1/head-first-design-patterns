using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public interface PizzaIngredientFactory
    {
        public Dough CreateDough();
        public Sauce CreateSauce();
        public Cheese CreateCheese();
    }
}
