using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Elective_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, x1, x2, y, y1, y2;
            const double phi = 1.618;
            double a = -2;
            double b = 2;
            double eps = 0.001;

            Console.WriteLine($"На отрезке [{a}, {b}]:");

            while (true)
            {
                
                x1 = b - (b - a) / phi;
                x2 = a + (b - a) / phi;

                y1 = Math.Pow((x1 + 1), 3) + 5 * x1 * x1;
                y2 = Math.Pow((x2 + 1), 3) + 5 * x2 * x2;

                if (y1 >= y2) // Поиск min
                    a = x1;
                else
                    b = x2;

                if (Math.Abs(b - a) < eps)
                {
                    x = (a + b) / 2;
                    y = Math.Pow((x + 1), 3) + 5 * x * x;
                    Console.WriteLine($"min = {y}");
                    break;
                }
            }

            a = -2;
            b = 2;

            while (true)
            {

                x1 = b - (b - a) / phi;
                x2 = a + (b - a) / phi;

                y1 = Math.Pow((x1 + 1), 3) + 5 * x1 * x1;
                y2 = Math.Pow((x2 + 1), 3) + 5 * x2 * x2;

                if (y1 <= y2) // Поиск max
                    a = x1;
                else
                    b = x2;

                if (Math.Abs(b - a) < eps)
                {
                    x = (a + b) / 2;
                    y = Math.Pow((x + 1), 3) + 5 * x * x;
                    Console.WriteLine($"max = {y}");
                    break;
                }
            }

            a = -8;
            b = 0;
            Console.WriteLine($"\nНа отрезке [{a}, {b}]:");

            while (true)
            {

                x1 = b - (b - a) / phi;
                x2 = a + (b - a) / phi;

                y1 = Math.Pow((x1 + 1), 3) + 5 * x1 * x1;
                y2 = Math.Pow((x2 + 1), 3) + 5 * x2 * x2;

                if (y1 >= y2) // Поиск min
                    a = x1;
                else
                    b = x2;

                if (Math.Abs(b - a) < eps)
                {
                    x = (a + b) / 2;
                    y = Math.Pow((x + 1), 3) + 5 * x * x;
                    Console.WriteLine($"min = {y}");
                    break;
                }
            }

            a = -8;
            b = 0;

            while (true)
            {

                x1 = b - (b - a) / phi;
                x2 = a + (b - a) / phi;

                y1 = Math.Pow((x1 + 1), 3) + 5 * x1 * x1;
                y2 = Math.Pow((x2 + 1), 3) + 5 * x2 * x2;

                if (y1 <= y2) // Поиск max
                    a = x1;
                else
                    b = x2;

                if (Math.Abs(b - a) < eps)
                {
                    x = (a + b) / 2;
                    y = Math.Pow((x + 1), 3) + 5 * x * x;
                    Console.WriteLine($"max = {y}");
                    break;
                }
            }
        }
    }
}
