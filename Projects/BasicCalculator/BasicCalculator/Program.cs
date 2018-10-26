using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {           
            int operation = 0;
            double result = 0;

            Console.WriteLine("Enter the operation + for Add, - for Subtract, * for Multiply, / for Divide or enter EXIT");
            string stringOperation = Console.ReadLine();

            

            
            if (stringOperation == "+" || stringOperation == "addition")
            {
                operation = 1;
            }
            else if (stringOperation == "-" || stringOperation == "subtraction")
            {
                operation = 2;
            }
            else if (stringOperation == "*" || stringOperation == "multiplication")
            {
                operation = 3;
            }
            else if (stringOperation == "/" || stringOperation == "division")
            {
                operation = 4;
            }


            switch (operation)
            {
                case 1:
                    Console.WriteLine("Enter your first number :");
                    string string1FirstNumber = Console.ReadLine();
                    double first1Number = Convert.ToDouble(string1FirstNumber);


                    Console.WriteLine("Enter your second number :");
                    string string1SecondNumber = Console.ReadLine();
                    double second1Number = Convert.ToDouble(string1SecondNumber);
                    result = first1Number + second1Number;
                    Console.WriteLine("\nResult of " + first1Number + " " + stringOperation + " " + second1Number + " = " + result + ".");
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("Enter your first number :");
                    string string2FirstNumber = Console.ReadLine();
                    double first2Number = Convert.ToDouble(string2FirstNumber);


                    Console.WriteLine("Enter your second number :");
                    string string2SecondNumber = Console.ReadLine();
                    double second2Number = Convert.ToDouble(string2SecondNumber);
                    result = first2Number - second2Number;
                    Console.WriteLine("\nResult of " + first2Number + " " + stringOperation + " " + second2Number + " = " + result + ".");
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("Enter your first number :");
                    string string3FirstNumber = Console.ReadLine();
                    double first3Number = Convert.ToDouble(string3FirstNumber);


                    Console.WriteLine("Enter your second number :");
                    string string3SecondNumber = Console.ReadLine();
                    double second3Number = Convert.ToDouble(string3SecondNumber);
                    result = first3Number * second3Number;
                    Console.WriteLine("\nResult of " + first3Number + " " + stringOperation + " " + second3Number + " = " + result + ".");
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("Enter your first number :");
                    string string4FirstNumber = Console.ReadLine();
                    double first4Number = Convert.ToDouble(string4FirstNumber);


                    Console.WriteLine("Enter your second number :");
                    string string4SecondNumber = Console.ReadLine();
                    double second4Number = Convert.ToDouble(string4SecondNumber);
                    result = first4Number / second4Number;
                    Console.WriteLine("\nResult of " + first4Number + " " + stringOperation + " " + second4Number + " = " + result + ".");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Thanks for stopping by!");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }
            
           


        }
    }
}