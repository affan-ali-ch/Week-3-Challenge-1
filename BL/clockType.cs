using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1.BL
{
    internal class clockType
    {
        public int hours;
        public int minutes;
        public int seconds;


        public clockType()
        {
            hours = 12;
            minutes = 12;
            seconds = 12;
        }

        public clockType(int hours)
        {
            this.hours = hours;
        }

        public clockType(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }

        public clockType(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public void Print()
        {
            Console.WriteLine("{0}:{1}:{2}", hours, minutes, seconds);
        }

        public void IncrementHours()
        {
            hours++;
        }
        public void IncrementMinutes()
        {
            minutes++;
        }
        public void IncrementSeconds()
        {
            seconds++;
        }

        public bool IsEqual(int hours, int minutes, int seconds)
        {
            if(this.hours == hours && this.minutes == minutes && this.seconds == seconds)
            {
                return true;
            }
            return false;
        }
        public bool IsEqual(clockType InputTime)
        {
            if( (InputTime.hours == hours) && (InputTime.minutes == minutes) && (InputTime.seconds == seconds) )
            {
                return true;
            }
            return false;
        }

        public int ElapsedTime()
        {
            return (hours * 3600) + (minutes * 60) + seconds;
        }
        
        public int RemainingTime()
        {
            int hours = 24 - this.hours;

            return (hours * 3600) + (minutes * 60) + seconds;
        }
        public void Difference(clockType Time)
        {
            int hours = this.hours - Time.hours;
            int minutes = this.minutes - Time.minutes;
            int seconds = this.seconds - Time.seconds;

            Console.WriteLine("{0}:{1}:{2}", Math.Abs(hours), Math.Abs(minutes), Math.Abs(seconds));
        }
    }
}
