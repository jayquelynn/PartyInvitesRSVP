using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Formulas2
{
    class Program
    {
        public static void Main()
        {
            double r, vol;
            Console.Write("Specify the radius of the sphere r = ");
            r = Convert.ToDouble(Console.ReadLine());

            vol = 4 * Math.PI * Math.Pow(r, 3) / 3;

            //the result will be shown with two decimal places
            Console.WriteLine("The volume of a sphere with the radius of {0} is {1:##.##}", r, vol);
            Console.ReadLine();
        }
    }
}
