using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerColor_HW_2C
{
    class TheClearPicture
    {
        static void Main(string[] args)
        {
            void FlowerColors(string flower, string color)
            {
                Console.WriteLine($"The {flower} is \"{color}\"!");
            }

            // Calls the two-parameter method with a default color
            void FlowerColor(string flower)
            {
                FlowerColors(flower, "purple" );
            }

            // Calls the one-parameter method with a default flower
            // OR
            // Calls the two-parameter method with a default flower and color
            {
                FlowerColor("tulip");
                // OR
                // FlowerColor("tulip", "purple");
            }

        }
    }
}
