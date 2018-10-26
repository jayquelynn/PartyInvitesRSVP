using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Formulas3
{
    class AreaTriangle
    {
        static void Main()
        {
            //Triangle Area = 1/2(base x height)
            Console.Write("Please write the \"b\" value of your triangle: ");
            decimal bSide = decimal.Parse(Console.ReadLine());
            Console.Write("Please write the \"h\" value of your triangle: ");
            decimal hSide = decimal.Parse(Console.ReadLine());

            decimal area = (bSide * hSide) / 2;
            Console.WriteLine("The area of your triangle is: {0}", area);
        }
    }
}
