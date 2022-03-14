using System;

namespace PizzaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaStore pizzaStore = new ChicagoPizzaStore();
            Pizza ourPizza = pizzaStore.OrderPizza("PineApples");
            Console.ReadLine();
        }

    }
}