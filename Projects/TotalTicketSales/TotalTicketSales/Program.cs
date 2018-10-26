using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalTicketSales
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, totalsales;

            Console.WriteLine("Please enter desired amount of tickets for A");
            A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter desired amount of tickets for B");
            B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter desired amount of tickets for C");
            C = Convert.ToDouble(Console.ReadLine());

            totalsales = (A * 15) + (B * 12) + (C * 9);

            Console.WriteLine($"Class A sold {A} tickets");
            Console.WriteLine($"Class B sold {B} tickets");
            Console.WriteLine($"Class C sold {C} tickets");

            Console.WriteLine($"Total sales is ${totalsales}");

            Console.ReadLine();
            
        }
    }
}
