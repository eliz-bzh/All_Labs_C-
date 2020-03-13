using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Time
    {
        private int hours;
        private int minutеs;
        private int seconds;

        public int Hours
        {
            get => hours;
            set
            {
                if (value >= 0 && value < 24)
                {
                    hours = value;
                }
                else
                {
                    throw new Exception("Value should be from 0 to 24");
                }
            }
        }
        public int Minutеs
        {
            get => minutеs;
            set
            {
                if (value >= 0 && value < 60)
                {
                    minutеs = value;
                }
                else
                {
                    throw new Exception("Value should be from 0 to 60");
                }
            }
        }
        public int Seconds
        {
            get => seconds;
            set
            {
                if (value >= 0 && value < 60)
                {
                    seconds = value;
                }
                else
                {
                    throw new Exception("Value should be from 0 to 60");
                }
            }
        }

        public Time() : this(0, 0, 0) { }
        public Time(int hour, int minutеs, int seconds)
        {
            Hours = hour;
            Minutеs = minutеs;
            Seconds = seconds;
        }

        public static int ConvertToSeconds(Time time)
        {
            return time.Hours * 3600 + time.Minutеs * 60 + time.Seconds;
        }

        public Time TimeInterval()
        {
            DateTime time = DateTime.Now;
            return new Time(time.Hour - Hours, time.Minute - Minutеs, time.Second - Seconds);
        }

        public override string ToString()
        {
            return Hours + ":" + Minutеs + ":" + Seconds;
        }
    }
}
