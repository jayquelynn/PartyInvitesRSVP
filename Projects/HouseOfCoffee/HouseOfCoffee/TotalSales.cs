using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseOfCoffee
{
    class TotalSales
    {
        double costOfItems;
        //How much money organization spent on product
        double totalSpendCost;
        //Total cost of money spent on product
        double priceSold;
        //Price of the product that was sold at by the Coffee Shop
        double totalSold;
        //Total amount of money made on product in a day
        double Profit;
        //How much money was made from merchandise
        double smallCost = 0.1;
        double smallSoldPrice = 1.00;
        double smallProfit = 0.90;
        double mediumCost = 0.15;
        double mediumSoldPrice = 3.00;
        double mediumProfit = 2.85;
        double largeCost = 0.2;
        double largeSoldPrice = 5.00;
        double largeProfit = 4.80;
        double eggSandwichCost = 0.95;
        double eggSandwichSoldPrice = 5.50;
        double eggSandwichProfit = 4.55;
        double chickenBiscuitCost = 1.20;
        double chickenBiscuitSoldPrice = 7.50;
        double chickenBiscuitProfit = 6.30;
        static void OneDaySales()
        {

        }

        public TotalSales()
        {

        }
        public void CostForItem()
        {

            Console.WriteLine("1. Sales");
            Console.WriteLine("How many cups of Small Coffee was bought?");
            double price1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many cups of Small Coffee did you sell today?");
            double price11 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many cups of Medium Coffee was bought?");
            double price2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many cups of Medium Coffee did you sell today?");
            double price22 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many cups of Large Coffee was bought?");
            double price3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many cups of Large Coffee did you sell today?");
            double price33 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many Egg Sandwiches were bought?");
            double price4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many Egg Sandwiches did you sell today?");
            double price44 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many Chicken Biscuits were bought?");
            double price5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many Chicken Biscuits did you sell today?");
            double price55 = Convert.ToDouble(Console.ReadLine());

            double totalSpendCost = (smallCost * price1) + (mediumCost * price2) + (largeCost * price3) + (eggSandwichCost * price4) + (chickenBiscuitCost * price5);
            double totalSold = (smallSoldPrice * price11) + (mediumSoldPrice * price22) + (largeSoldPrice * price33) + (eggSandwichSoldPrice * price44) + (chickenBiscuitSoldPrice * price55);
            double Profit = (smallSoldPrice - smallCost);

            Console.WriteLine($"The total amount of money spent on product is: {totalSpendCost:c}");
            Console.WriteLine($"The total amount of money you made today is: {totalSold:c}");
            Console.WriteLine($"The total of profit you made today is: {Profit:c}");
        }

    }

}
