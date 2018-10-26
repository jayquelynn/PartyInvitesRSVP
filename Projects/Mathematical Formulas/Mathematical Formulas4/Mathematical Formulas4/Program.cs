using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Formulas4
{
    class QuadraticEquations
    {
        double Qa, Qb, Qc;
        static void read()
        {
            Console.WriteLine(" \n To find the roots of a quadratic equation of the form a*x*x + b*x + c = 0");
            Console.Write("\n Enter value for Qa : ");
            Qa = double.Parse(Console.ReadLine());
            Console.Write("\n Enter value for Qb : ");
            Qb = double.Parse(Console.ReadLine());
            Console.Write("\n Enter value for Qc : ");
            Qc = double.Parse(Console.ReadLine());
        }
        public void compute()
        {
            int m;
            double r1, r2, d1;
            d1 = Qb * Qb - 4 * Qa * Qc;
            if (Qa == 0)
                m = 1;
            else if (d1 > 0)
                m = 2;
            else if (d1 == 0)
                m = 3;
            else
                m = 4;
            switch (m)
            {
                case 1:
                    Console.WriteLine("\n Not a Quadratic equation, Linear equation");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("\n Roots are Real and Distinct");
                    r1 = (-Qb + Math.Sqrt(d1)) / (2 * Qa);
                    r2 = (-Qb - Math.Sqrt(d1)) / (2 * Qa);
                    Console.WriteLine("\n First root is {0:#.##}", r1);
                    Console.WriteLine("\n Second root is {0:#.##}", r2);
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("\n Roots are Real and Equal");
                    r1 = r2 = (-Qb) / (2 * Qa);
                    Console.WriteLine("\n First root is {0:#.##}", r1);
                    Console.WriteLine("\n Second root is {0:#.##}", r2);
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("\n Roots are Imaginary");
                    r1 = (-Qb) / (2 * Qa);
                    r2 = Math.Sqrt(-d1) / (2 * Qa);
                    Console.WriteLine("\n First root is {0:#.##} + i {1:#.##}", r1, r2);
                    Console.WriteLine("\n Second root is {0:#.##} - i {1:#.##}", r1, r2);
                    Console.ReadLine();
                    break;
            }
        }
    }

    class Roots
    {
        public static void Main()
        {
            QuadraticEquations qr = new QuadraticEquations();
            qr.read();
            qr.compute();
        }
    }
}
