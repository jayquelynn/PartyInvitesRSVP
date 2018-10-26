using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors_and_Exceptions_of_formulas
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Enter the number for desired mathematical formula");

            Console.WriteLine("Mathematical Operators");
            Console.WriteLine("1. Circles");
            Console.WriteLine("2. Triangles");
            Console.WriteLine("3. Hemispheres");
            Console.WriteLine("4. Quadratic Formula");
            Console.WriteLine("5. Exit");
            string stringOperation = Console.ReadLine();


            switch (stringOperation)
            {
                case "1":

                    Console.WriteLine("Enter the radius of your circle: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    CircumferenceandArea(radius);
                    Console.ReadLine();
                    break;

                case "2":

                    Console.WriteLine("Enter the base of your triangle: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the height of your triangle: ");
                    double h = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the area of your triangle: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    AreaofTriangle(b, h, a);
                    Console.ReadLine();
                    break;

                case "3":

                    Console.WriteLine("Enter the volume of your hemisphere: ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    VolumeofHemisphere(r);
                    Console.ReadLine();
                    break;

                case "4":

                    Console.WriteLine("Enter the roots of a Quadratic Equation");
                    Console.WriteLine("Enter the value for Qa: ");
                    double Qa = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the value for Qb: ");
                    double Qb = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the value for Qc: ");
                    double Qc = Convert.ToDouble(Console.ReadLine());
                    QuadraticEquations(Qa, Qb, Qc);
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Thanks for stopping by!");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }
        }

        static void CircumferenceandArea(double radius)
        {
            double circumference = 2 * radius * Math.PI;
            double area = 2 * Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The circumference is {circumference:0.00} and area is {area:0.00}");
            Console.WriteLine("This program has finally terminated. Goodbye.");
        }

        static void AreaofTriangle(double b, double h, double a)
        {
            double p = (a + b + h) / 2.0;
            double area = (b * h) / 2;
            Console.WriteLine($"The area is {area:0.00}");
            Console.WriteLine("This program has finally terminated. Goodbye.");
        }

        static void VolumeofHemisphere(double r)
        {
            double PI = Math.PI;
            double Volume = (2 / 3) * PI * Math.Pow(r, 3);
            Console.WriteLine($"The volume is {Volume:0.00}");
            Console.WriteLine("This program has finally terminated. Goodbye.");
        }

        static void QuadraticEquations(double Qa, double Qb, double Qc)
        {

            double sqrt = (Qb * Qb) - (4 * Qa * Qc);
            double x1 = -Qb + (Math.Sqrt(sqrt) / (2 * Qa));
            double x2 = -Qb - (Math.Sqrt(2) / (2 * Qa));
            Console.WriteLine($"The Square Root is {sqrt: 0.00}");
            Console.WriteLine("This program has finally terminated. Goodbye.");
        }

    }
}