using System;

namespace ProjectRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты первой вершины прямоугольника:");
            Console.WriteLine("x1 =");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("y1 =");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты противоположной вершины прямоугольника:");
            Console.WriteLine("x2 =");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("y2 =");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Координаты противоположных вершин прямоугольника: ({0}; {1}) и ({2}; {3})", x1, y1, x2, y2);
            Console.WriteLine("Периметр прямоугольника = {0}", CalculateRectanglePerimeterByTwoPoints(x1, y1, x2, y2));
            Console.WriteLine("Площадь прямоугольника = {0}", CalculateRectangleAreaByTwoPoints(x1, y1, x2, y2));

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }

        static double CalculateRectanglePerimeterByTwoPoints(double x1, double y1, double x2, double y2)
        {
            return 2 * (Math.Abs(x2 - x1) + Math.Abs(y2 - y1));
        }

        static double CalculateRectangleAreaByTwoPoints(double x1, double y1, double x2, double y2)
        {
            return Math.Abs((x2 - x1) * (y2 - y1));
        }
    }
}
