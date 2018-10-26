using Classes;
using System;

namespace ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateWorker();
        }
        /// <summary>
        /// User enters which shift they work
        /// </summary>
        /// <returns></returns>
        static int GetShiftInfo()
        {
            string input;
            do
            {
                Console.WriteLine("Please enter the shift you work: 1 for Day Shift or 2 for Night shift");
                input = Console.ReadLine();

            } while (!IsNumeric(input) || !IsInRange(Convert.ToInt32(input)));

            return Convert.ToInt32(input);
        }
        /// <summary>
        /// Checks if value within range
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static bool IsInRange(int input)
        {
            return (input >= 1 && input <= 2);
        }

        /// <summary>
        /// Check if value is numeric
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static bool IsNumeric(string input)
        {
            int test;
            return int.TryParse(input, out test);
        }

        /// <summary>
        /// Creates an instance of a ProcessWorker and
        /// asks the user for information regarding the process worker
        /// </summary>
        static void CreateWorker()
        {
            ProductionWorker pw = new ProductionWorker
            {
                EmployeeId = 101
            };

            Console.WriteLine("Please enter your first name");
            pw.FirstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name");
            pw.LastName = Console.ReadLine();

            Console.WriteLine($"Your name is: {pw.GetName()}");

            pw.Shift = GetShiftInfo();
            Console.WriteLine($"{pw.WorkingShift()}");

            Console.ReadLine();

        }
    }
}
