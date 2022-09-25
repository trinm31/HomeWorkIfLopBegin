using System;

namespace HaiSoBangNhau
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Let's input a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Let's input b:");
            b = Convert.ToDouble(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("a equal b");
            }
            else
            {
                Console.WriteLine("a not equal b");
            }

            Console.ReadKey();
        }
    }
}