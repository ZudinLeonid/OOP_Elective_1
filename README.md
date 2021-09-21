# OOP_Elective_1
Первое домашнее задание по факультативу ООП
Выполнил: Зудин Леонид Дмитриевич гр. 590-1
Задание: Написать программу поиска экстремума функции на заданном отрезке методом золотого сечения. Алгоритм реализации можно взять с википедии. Функцию и отрезок на котором будете производить поиск min и max можете взять произвольные на свое усмотрение, либо y = (x + 1)^3 + 5*x^2 на отрезке [-2; 2], [-8; 0]. Производить вычисление с точностью - 0.001. Приложение необходимо реализовать на языке C#. Платформу выбираете также на ваше усмотрение: .NET Framework 4.8.2, .NET Core 3.1, .NET 5.0.
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
