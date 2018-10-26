using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ProductionWorker: Employee
    {
        
        public  ProductionWorker()
        {
            this.Shift = 0;
        }
        public int Shift { get; set; }
        public double PayRate { get; set; }

        public string WorkingShift()
        {
            if (this.Shift == 1) return "I work the day shift.";
            if (this.Shift == 2) return "I work the night shift.";
            return "I enjoy my time off.";
        }
    }
}
