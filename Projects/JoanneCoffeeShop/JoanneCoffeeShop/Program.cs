using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HouseOfCoffee
{
    class Options
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 1 for your Daily Total." +
                " For Weekly Payroll, enter 2." +
                " For the Menu, enter 3." +
                " To Exit, enter 4.");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Options");
            Console.WriteLine("1. Daily Total");
            Console.WriteLine("2. Weekly Payroll and Overtime");
            Console.WriteLine("3. Menu");
            Console.WriteLine("4. Quit");
            string stringOptions = Console.ReadLine();

            switch (stringOptions)
            {
                case "1":

                    Console.WriteLine("1. Daily Total");
                    double DT = Convert.ToDouble(Console.ReadLine());
                    Console.ReadLine();
                    break;

                case "2":

                    Console.WriteLine("2. Weekly Payroll and Overtime");
                    double WPnO = Convert.ToDouble(Console.ReadLine());
                    Console.ReadLine();
                    break;

                case "3":

                    Console.WriteLine("3. Menu");
                    double menu = Convert.ToDouble(Console.ReadLine());
                   
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Thanks. Come again soon!");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }
        }   

    }
}
