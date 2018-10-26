using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoanneCoffeeShop
{
    class Weekly_Payroll
    {
        public enum PayRoll
        { MONDAY, TUESDAY, WEDENSDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY }
        public double pay(double time, double payrate)
        {
            if (time <= 8)
                return payrate * time;
            else
                return payrate * 8 + payrate * (time - 8) / 2;
        }

        struct Time
        {
            private int hours, minutes, seconds;

            public Time(int hh, int mm, int ss)
            {
                this.hours = hh % 24;
                this.minutes = mm % 60;
                this.seconds = ss % 60;
            }

            public override string ToString()
            {
                string data = $"{this.hours} {this.minutes} {this.seconds}";
                return data;
            }

            public void AdvancePay()
            {
                this.hours++;
                if (this.hours == hours + 1)
                {
                    this.hours = hours;
                    this.minutes++;
                }
            }
            class TimeWorked
            {
                private Time currentTime;
                public void Method(Time parameter)
                {
                    Time localVariable;
                }
            }
        }
    }
}
