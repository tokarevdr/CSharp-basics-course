using System;

namespace NumericAxisTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точек на числовой оси:");
            Console.WriteLine("A = ");

            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("B = ");

            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("C = ");

            double c = Convert.ToDouble(Console.ReadLine());

            double distanceAB = 0;
            double distanceAC = 0;

            if (b == c)
            {
                if (a == c)
                {
                    Console.WriteLine("Координаты B и C совпадают с точкой A");
                }
                else
                {
                    Console.WriteLine("Координаты B и C совпадают между собой");
                }
            }
            else
            {
                distanceAB = Math.Abs(b - a);
                distanceAC = Math.Abs(c - a);

                if (distanceAB < distanceAC)
                {
                    Console.WriteLine($"Точка B находиться ближе к точке A (на расстоянии {distanceAB})");
                }
                else
                {
                    Console.WriteLine($"Точка C находиться ближе к точке A (на расстоянии {distanceAC})");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
