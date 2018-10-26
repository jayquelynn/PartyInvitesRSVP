using Car_ClassLibrary_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CarClass car = new CarClass(2018, "Honda");

            Console.WriteLine(car.Speed);

            for (int i = 0; i < 5; i++) 
            {
                car.Accelerate();
                Console.WriteLine(car.Speed);
            }
            for (int i = 0; i < 5; i++)
            {
                car.Brake();
                Console.WriteLine(car.Speed);
            }
            Console.ReadLine();
        }

    }
}
