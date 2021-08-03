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
            Console.WriteLine(DiscomfortMaxMinTime(5000, 1200, 100, 1));
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
        public static (double, double) DiscomfortMaxMinTime(int height, int time, int maxSpeed, int comfortSpeed)
        {
            var remainingHeight = height;
            var minDiscomfortTime = 0;
            var maxDiscomfortTime = 0;
            for (int t = time; t > 0; t-- )
            {
                if (t * maxSpeed > remainingHeight)
                {
                    remainingHeight = height - (time-t) * comfortSpeed;
                }
                else
                {
                    minDiscomfortTime = t;
                    break;
                }
            }

            for (int t = time; t > 0; t--)
            {
                if (t * comfortSpeed > remainingHeight)
                {
                    remainingHeight = height - (time - t) * maxSpeed;
                }
                else
                {
                    maxDiscomfortTime = t;
                    break;
                }
            }

            return (minDiscomfortTime, maxDiscomfortTime);
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
