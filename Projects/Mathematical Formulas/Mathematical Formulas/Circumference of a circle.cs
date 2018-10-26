using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Formulas
{
    class CirclePerimieter
    {
        static void Main()
        // Perimeter (Circumference) of a circle: C=2πr
        {
            Console.WriteLine("Please write the radius of your circle and click 'Enter' afterwards: ");
            double radius = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double area = 2 * pi * radius;
            Console.WriteLine("The Perimeter or Circumference (C=2πr) of your circle is: {0:F2}", area);
        }
    }
}