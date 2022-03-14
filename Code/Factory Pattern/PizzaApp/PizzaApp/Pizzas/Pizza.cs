using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public abstract class Pizza
    {
        public string name;
        public string dough;
        public string sauce;
        public List<string?> toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Preparing:");
        }

        public void Bake()
        {
            Console.WriteLine("Baked");
        }

        public void Cut()
        {
            Console.WriteLine("Cut");
        }

        public void Boxed()
        {
            Console.WriteLine("Boxed");
        }
    }
}
