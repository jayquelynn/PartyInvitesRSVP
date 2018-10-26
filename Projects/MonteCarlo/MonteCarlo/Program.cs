using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MonteCarlo
{
    class Program
    {
            static double MonteCarlo(int n)
            {
                int inside = 0;
                Random r = new Random();

                for (int i = 0; i < n; i++)
                {
                    if (Math.Pow(r.NextDouble(), 2) + Math.Pow(r.NextDouble(), 2) <= 1)
                    {
                        inside++;
                    }
                }

                return 4.0 * inside / n;
            }

            static void Main(string[] args)
            {
                int value = 1000;
                for (int n = 0; n < 5; n++)
                {
                    value *= 10;
                    Console.WriteLine("{0}:{1}", value.ToString("#,###").PadLeft(11, ' '), MonteCarlo(value));
                }
            }


        public struct XandY
        {
            public int x;
            public int y;

            public XandY(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
        }
    }
}

//QUESTIONS
//1. Why do we multiply the value from step 5 above by 4?
//Because that how many numbers are in a array

//2. What do you observe in the output when running your program with parameters of increasing size?
//I observe the number incrementing

//3. If you run the program multiple times with the same parameter, does the output remain the same? Why or why not?
//No, because it is using random numbers

//4. Find a parameter that requires multiple seconds of run time.What is that parameter? How accurate is the estimated value of π?
//void MethodName(object e, ElapsedEventArgs args) It allows to run the method only once.

//5. Research one other use of Monte-Carlo methods.Record it in your exercise submission and be prepared to discuss it in class.


