using System;

namespace Seminar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetSumm(16));
            var time = new Time(19, 44);            
            Console.WriteLine(time.GetAngleBetweenArrow());
        }

        public static int GetSumm(int startNumber, int summ = 0)
        {
            var nextNumber = --startNumber;
            if (nextNumber % 3 == 0 || nextNumber % 5 == 0)
                summ += nextNumber;
            if (nextNumber != 0)
                return GetSumm(nextNumber, summ);
            else
                return summ;
        }

        
    }

    public class Time
    {
        int Hour;
        int Minute;

        public Time(int hour, int minute)
        {
            Hour = hour / 12 == 0? hour : hour - 12;
            Minute = minute;
        }

        public int GetAngleBetweenArrow()
        {
            int angle = 6 * (5 * Hour - Minute);
            return Math.Abs(angle);
        }
    }
}
