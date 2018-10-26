using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Equipment
    {
        public void ShotSound(string noiseMadeWhenShot)
        {
            Console.WriteLine($"Sounds when shot: {noiseMadeWhenShot}");
        }

        public void StartSound(string noiseMadeWhenVehicleStarts)
        {
            Console.WriteLine($"Sound when vechicle is started: {noiseMadeWhenVehicleStarts}");
        }
    }
}
