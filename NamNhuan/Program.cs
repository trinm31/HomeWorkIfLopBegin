using System;

namespace NamNhuan
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. chia hết cho 4 những không chia hết cho 100
            // 2. chia hết cho 400
            int year;
            Console.WriteLine("Let's input year");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 400 == 0)
            {
                Console.WriteLine($"{year} is leap year");
            }
            else if (year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine($"{year} is leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not leap year");
            }
        }
    }
}