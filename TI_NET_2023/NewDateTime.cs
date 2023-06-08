using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023
{
    public struct NewDateTime
    {
        public NewDateTime(int day,string month,int year)
        {
            Day = day;
            Month = month;
            Year = year;
            Hour = 0;
            Minute = 0;
            Second = 0;
        }

        public NewDateTime(int year, string month, int day, int hour, int minute, int second)
        {
            Day = day;
            Month = month;
            Year = year;
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public int Year;

        public string Month;

        public int Day;

        public int Hour;

        public int Minute;

        public int Second;

        public override string ToString()
        {
            return $"{Day} {Month} {Year}";
        }
    }
}
