using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//Найти расстояние между двумя точками с заданными координатами (x1, y1) и (x2, y 2) на
//плоскости. Расстояние вычисляется по формуле √((𝑥2 − 𝑥1)^2 + (𝑦2 − 𝑦1)^2)

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Введите координаты первой точки(x1,y1):");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты второй точки(x2,y2):");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            if (Math.Abs(x1) >= 5 * Math.Pow(10, 324))
            {
                Console.WriteLine("Ошибка ввода!");
                Environment.Exit(0);
            }

            if (Math.Abs(y1) >= 5 * Math.Pow(10, 324))
            {
                Console.WriteLine("Ошибка ввода!");
                Environment.Exit(0);
            }

            if (Math.Abs(x2) >= 5 * Math.Pow(10, 324))
            {
                Console.WriteLine("Ошибка ввода!");
                Environment.Exit(0);
            }

            if (Math.Abs(y2) >= 5 * Math.Pow(10, 324))
            {
                Console.WriteLine("Ошибка ввода!");
                Environment.Exit(0);
            }

            Console.WriteLine("Координаты точек:");
            Console.WriteLine($"Первая точка:");
            Console.Write($"x1:{Math.Round(x1, 3)}");
            Console.Write($"  y1:{Math.Round(y1, 3)}\n");

            Console.WriteLine($"Вторая точка:");
            Console.Write($"x2:{Math.Round(x2, 3)}");
            Console.Write($"  y2:{Math.Round(y2, 3)}\n");

            double Area = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            Console.WriteLine($"Расстояние между точками:{Math.Round(Area, 3)}");

            Console.ReadKey();
        }
    }
}