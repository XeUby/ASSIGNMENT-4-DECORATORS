using DecoratorAssignment.BeveragesList;
using DecoratorAssignment.CondimentsList;
using System.Security.Cryptography.X509Certificates;

namespace DecoratorAssignment
{
  
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Espresso
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

            // Example 2: DarkRoast with Mocha and Whip
            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.Cost());

            // Example 3: HouseBlend with Soy, Mocha, and Whip
            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.GetDescription() + " $" + beverage3.Cost());
        }
    }
}
