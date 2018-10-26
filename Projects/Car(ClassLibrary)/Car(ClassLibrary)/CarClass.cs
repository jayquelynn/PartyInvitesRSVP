using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_ClassLibrary_
{
    public class CarClass
    {

        public int YearModel { get; set; }

        public string Make { get; set; }

        public int Speed { get; set; }

     

        public CarClass(int yearModel, string make)
        {
            this.YearModel = yearModel;
            this.Make = make;
            this.Speed = 0;
        }

        public void Accelerate()
        {
            this.Speed += 5;
        }
        
        public void Brake()
        {
            this.Speed -= 5;
        }
    }
}
