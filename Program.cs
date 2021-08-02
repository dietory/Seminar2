using System;

namespace Seminar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetSumm(16));
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
}
