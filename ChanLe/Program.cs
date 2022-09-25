using System;

namespace ChanLe
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Let's input a:");
            a = Convert.ToDouble(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("a is even number");
            }
            else
            {
                Console.WriteLine("a is odd number");
            }

            Console.ReadKey();
        }
    }
}