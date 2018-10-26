using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Vehicles : Equipment
    {
        public void JLTV()
        {
            Console.WriteLine("Joint Light Tactical Vehicle");
        }

        public void MTVR()
        {
            Console.WriteLine("Medium Tactical Vehicle Replacement");
        }

        public void HMMWV()
        {
            Console.WriteLine("High Mobility Multipurpose Wheeled Vehicle");
        }

        public void HEMTT()
        {
            Console.WriteLine("Heavy Expanded Mobility Tactical Truck");
        }
    }
}
