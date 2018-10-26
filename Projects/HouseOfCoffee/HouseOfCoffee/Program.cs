using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enumLibrary;

namespace HouseOfCoffee
{
    class Menu
    {
        static void Main(string[] args)
        {
            TotalSales totalsales = new TotalSales();

            Console.WriteLine("Please enter 1. for Sales, Enter 2. for payroll or To Exit, enter 3.");
            Console.WriteLine("--------------------------------------------------------------------");

            Console.WriteLine("Options");
            Console.WriteLine("1. Sales");
            Console.WriteLine("2. Payroll");
            Console.WriteLine("3. Quit");
            string stringProgram = Console.ReadLine();

            switch (stringProgram)
            {
                case "1":

                    totalsales.CostForItem();
                    Console.ReadLine();
                    break;

                case "2":

                    WeeklyPayroll.EmployeePay();
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
