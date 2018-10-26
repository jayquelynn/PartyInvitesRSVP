using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enumLibrary;

namespace HouseOfCoffee
{
    public struct WeeklyPayroll
    {

        public static double hoursWorked = 00;
        //Total hours worked
        public static double hourlyPayRate = 0.00;
        //hourly wage
        public static double regularPay = 0.00;
        //Amount made if employee worked 40 hours
        public static double overtimePay = 0.00;
        //Amount made if employee worked over 40 hours
        public static double overtimeHours = 0.00;
        //Hours of overtime
        static double overtimeEarnings = 0.00;
        static double Total = 0.00;

        static void PayRollWeekly()
        {

        }

        public static void EmployeePay()
        {
            try
            {
                double regularEarnings = 0.00;
                double overtimeEarnings = 0.00;
                double regularHours = 0.00;
                double overtimeHours = 0.00;
                const double baseHours = 40;
                const double overtimeRate = 1.5;

                for (int i = 0; i < 5; i++)
                {
                    
                    Console.WriteLine("Please enter how many hours each employee worked this week.");
                    double hours = Convert.ToDouble(Console.ReadLine());

                    if (hours > 40)
                    {
                        regularHours += 40; 
                        overtimeHours += (hours - 40) * (1.5);
                    }
                    else if (hours <= 40)
                    {
                        regularHours += (hours);
                    }
                }
                regularEarnings = (regularHours * 12.5);
                overtimeEarnings = (overtimeHours * 12.5);
                Total += (regularEarnings + overtimeEarnings);
                Console.WriteLine($"The total amount of regular earnings is: {regularEarnings:c}");
                Console.WriteLine($"The total amount of overtime earnings is: {overtimeEarnings:c}");
                Console.WriteLine($"The final total of earnings is: {Total:c}");
                Environment.Exit(0);
            }
            catch (Exception ex) { };
        }
    }
}