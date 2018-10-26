using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //SUM OF EACH ARRAY
            {
                int[] arrayA = { 0, 2, 4, 6, 8, 10 };
                Console.WriteLine("The sum of Array A is:");
                Console.WriteLine(arrayA.Sum());

                int[] arrayB = { 1, 3, 5, 7, 9 };
                Console.WriteLine("The sum of Array B is:");
                Console.WriteLine(arrayB.Sum());

                int[] arrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9, };
                Console.WriteLine("The sum of Array C is:");
                Console.WriteLine(arrayC.Sum());
            }


            Console.WriteLine("_______________________________");
            {
                //ARRAYS REVERSED
                Console.WriteLine("ArrayA reversed is:");
                var arrayA1 = new[] { 0, 2, 4, 6, 8, 10 };
                var result = new double[arrayA1.Length];
                for (int i = arrayA1.Length - 1; i >= 0; i--)
                {
                    result[arrayA1.Length - i - 1] = arrayA1[i];
                }
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
                Console.ReadKey();

                Console.WriteLine("ArrayB reversed is:");
                var arrayB1 = new[] { 1, 3, 5, 7, 9 };
                var result1 = new double[arrayA1.Length];

                for (int i = arrayB1.Length - 1; i >= 0; i--)
                {
                    result[arrayB1.Length - i - 1] = arrayB1[i];
                }
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
                Console.ReadKey();

                Console.WriteLine("ArrayC reversed is:");
                var arrayC1 = new[] { 3, 1, 4, 1, 5, 9 };
                var result2 = new double[arrayC1.Length];

                for (int i = arrayC1.Length - 1; i >= 0; i--)
                {
                    result[arrayC1.Length - i - 1] = arrayC1[i];
                }
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
                Console.ReadKey();
                var arrayC2 = new[] { 2, 6, 5, 3, 5, 9 };
                var result3 = new double[arrayC1.Length];

                for (int i = arrayC1.Length - 1; i >= 0; i--)
                {
                    result[arrayC1.Length - i - 1] = arrayC1[i];
                }
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
                Console.ReadKey();
            }
            Console.WriteLine("_______________________________________");






            {
                //ARRAYS ROTATED
                Console.WriteLine("ArrayA rotated:");
                var array = new string[] { "0", "2", "4", "6", "8", "10" };
                Console.WriteLine($"Before rotate {string.Join(", ", array)}");
                LeftRotate(array);
                Console.WriteLine($"After rotate {string.Join(", ", array)}");

                Console.ReadKey();
            }
            void LeftRotate(string[] array)
            {
                var first = array[0];

                for (var i = 1; i < array.Length; i++)
                {
                    array[i - 1] = array[i];
                }

                array[array.Length - 1] = first;
            }

            {
                Console.WriteLine("ArrayB rotated:");
                var array = new string[] { "1", "3", "5", "7", "9" };
                Console.WriteLine($"Before rotate {string.Join(", ", array)}");
                LeftRotate(array);
                Console.WriteLine($"After rotate {string.Join(", ", array)}");

                Console.ReadKey();
            }
            void RotateLeft(string[] array)
            {
                var first = array[0];

                for (var i = 1; i < array.Length; i++)
                {
                    array[i - 1] = array[i];
                }

                array[array.Length - 1] = first;
            }

            {
                Console.WriteLine("ArrayC rotated:");
                var array = new string[] { "3", "1", "4", "1", "5", "9", "2", "6", "5", "3", "5", "9"};
                Console.WriteLine($"Before rotate {string.Join(", ", array)}");
                LeftRotate(array);
                Console.WriteLine($"After rotate {string.Join(", ", array)}");

                Console.ReadKey();
            }
            void RotatedLeft(string[] array)
            {
                var first = array[0];

                for (var i = 1; i < array.Length; i++)
                {
                    array[i - 1] = array[i];
                }

                array[array.Length - 1] = first;
            }
            Console.WriteLine("_____________________________");




            {
                //ARRAYC SORTED IN ORDER
                Console.WriteLine("ArrayC is sorted as:");
                int[] ArrayC = new int [12] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
                int temp = 0;
                Console.ReadKey();

                for(int i = 0; i < ArrayC.Length; i++)
                {
                    for (int j = 0; j < ArrayC.Length; j++)
                    {
                        if( ArrayC[i] < ArrayC[j])
                        {
                            temp = ArrayC[i];

                            ArrayC[i] = ArrayC[j];

                            ArrayC[j] = temp;
                        }
                    }
                }
                
                for (int i = 0; i < ArrayC.Length; i++)
                {
                    Console.Write("{0}," , ArrayC[i]);
                }
            }
        }
    }
}
