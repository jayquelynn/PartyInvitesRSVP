using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlySalesTax
{
    class MonthlySalesTax
    {
        static void Main(string[] args)
        {
            double x, countysalestax, statesalestax, totalsalestax, p;
            Console.WriteLine("Input total of monthly sales.");
            x = Convert.ToDouble (Console.ReadLine());

            double state = 0.04 * x;
            double county = 0.02 * x;
            double totaltax = state * county;
            double total = x + state + county;

            Console.WriteLine($"County tax is ${county}");
            Console.WriteLine($"State tax is ${state}");
            Console.WriteLine($"Total tax is ${totaltax}");
            Console.WriteLine($"Your total tax is ${total}");

            Console.ReadLine();
        }
    }
}
