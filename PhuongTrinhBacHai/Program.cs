using System;

namespace PhuongTrinhBacHai
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            double alpha, x1, x2;
            Console.WriteLine("Giai phuong trinh bac 2 có dang ax^2 + bx + c = 0");
            Console.WriteLine("Let's input a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Let's input b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Let's input c:");
            c = Convert.ToInt32(Console.ReadLine());

            alpha = b * b - 4 * a * c;

            if (alpha == 0)
            {
                Console.WriteLine("Phuong trinh co nghiem kep");
                x1 = -b / 2 * a;
                x2 = x1;
                Console.WriteLine($"Nghiem cua phuong trinh x1 = {x1}, x2 = {x2}");
            }
            else if (alpha > 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem phan biet");
                x1 = (-b + Math.Sqrt(alpha)) / (2 * a);
                x2 = (-b - Math.Sqrt(alpha)) / (2 * a);
                Console.WriteLine($"Nghiem cua phuong trinh x1 = {x1}, x2 = {x2}");
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }

            Console.ReadKey();
        }
    }
}