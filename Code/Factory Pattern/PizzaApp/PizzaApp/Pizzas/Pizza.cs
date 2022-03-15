using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public abstract class Pizza
    {
        public Dough Dough;
        public Sauce Sauce;
        public Cheese Cheese;

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Pizza is being baked.");
        }

        public void Cut()
        {
            Console.WriteLine("Pizza is being cut.");
        }

        public void Boxed()
        {
            Console.WriteLine("Pizza is being boxed.");
        }
    }
}
