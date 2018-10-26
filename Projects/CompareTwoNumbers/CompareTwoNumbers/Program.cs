using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTwoNumbers
{
    class Program
    {
        public static void Main()
        {
            int n, x;
            Console.WriteLine("Input two number: ");
            n = Convert.ToInt32(Console.ReadLine());
            x = Convert.ToInt32(Console.ReadLine());

            if (n > x)
            {
                Console.WriteLine("{0} is the greater number! Congratulations, you have successfully found the greater number!", n);
                Console.ReadLine();
            }
            else if (n < x)
            {
                Console.WriteLine("{0} is the greater number! Congratulations, you have successfully found the greater number!", x);
                Console.ReadLine();
            }
            else if (n == x)
            {
                Console.WriteLine("{0} is equal to {0}!", n & x);
                Console.ReadLine();
            }   
            else
            {
             Console.WriteLine("Goodbye!");
             Console.ReadLine();
            }
        }
    }
}
