using System;

namespace PizzaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaStore chicagoPizzaStore = new ChicagoPizzaStore();
            chicagoPizzaStore.OrderPizza();
            Console.WriteLine();

            PizzaStore californiaPizzaStore = new CaliforniaPizzaStore();
            californiaPizzaStore.OrderPizza();
            Console.WriteLine();

            PizzaStore newYorkPizzaStore = new NewYorkPizzaStore();
            newYorkPizzaStore.OrderPizza();
            Console.WriteLine();

            Console.ReadLine();

        }

    }
}