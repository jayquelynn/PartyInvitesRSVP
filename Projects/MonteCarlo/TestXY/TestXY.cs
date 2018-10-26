using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonteCarlo;

namespace TestXY
{
    class TestCoOrds
    {
        static void Main()
        {   
            XandY XandY1 = new XandY();
            XandY XandY2 = new XandY();

            Console.Write("XandY1: ");
            Console.WriteLine("x = {0}, y = {1}", XandY1.x, XandY1.y);

            Console.Write("XandY2: ");
            Console.WriteLine("x = {0}, y = {1}", XandY2.x, XandY2.y);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
    internal class XandY
    {
        internal readonly int x;
        internal readonly int y;
    }
}
