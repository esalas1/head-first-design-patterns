// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Beverage
{
    private double milkCost;
    private double soyCost;
    private double mochaCost;
    private double whipCost;

    private bool hasMilk;
    private bool hasSoy;
    private bool hasMopcha;
    private bool hasWhip;
    public double Cost()
    {
        double cost = 0;
        
        if (hasMilk)
        {
            cost += milkCost;
        }

        if (hasSoy)
        {
            cost += soyCost;
        }

        if (hasMopcha)
        {
            cost += mochaCost;
        }

        if (hasWhip)
        {
            cost += whipCost;
        }

        return cost;
    }
}

public class DarkRoast : Beverage
{

    public double Cost()
    {
        double addedCost = 2.00;

        return addedCost + base.Cost();
    }
}