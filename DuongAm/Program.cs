using System;

namespace DuongAm
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Let's input a:");
            a = Convert.ToDouble(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("a is positive number");
            }
            else
            {
                Console.WriteLine("a is negative number");
            }

            Console.ReadKey();
        }
    }
}