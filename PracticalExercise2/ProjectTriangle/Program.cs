using System;

namespace ProjectTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты первой вершины треугольника:");
            Console.WriteLine("x1 =");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("y1 =");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты второй вершины треугольника:");
            Console.WriteLine("x2 =");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("y2 =");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты третьей вершины треугольника:");
            Console.WriteLine("x3 =");
            double x3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("y3 =");
            double y3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Треугольник с координатами: ({0}; {1}) ({2}; {3}) ({4}; {5})", x1, y1, x2, y2, x3, y3);
            Console.WriteLine("Периметр треугольника = {0}", CalculateTrianglePerimeterByThreePoints(x1, y1, x2, y2, x3, y3));
            Console.WriteLine("Площадь треугольника = {0}", CalculateTriangleAreaByThreePoints(x1, y1, x2, y2, x3, y3));

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }

        static double CalculateTriangleAreaByHeronsFormula(double side1Length, double side2Length, double side3Length)
        {
            double halfPerimeter = (side1Length + side2Length + side3Length) / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - side1Length) * (halfPerimeter - side2Length) * (halfPerimeter - side3Length));
        }

        static double CalculateEuclideanDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static double CalculateTrianglePerimeterByThreePoints(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double a = CalculateEuclideanDistance(x1, y1, x2, y2);
            double b = CalculateEuclideanDistance(x2, y2, x3, y3);
            double c = CalculateEuclideanDistance(x3, y3, x1, y1);

            return a + b + c;
        }

        static double CalculateTriangleAreaByThreePoints(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double a = CalculateEuclideanDistance(x1, y1, x2, y2);
            double b = CalculateEuclideanDistance(x2, y2, x3, y3);
            double c = CalculateEuclideanDistance(x3, y3, x1, y1);

            return CalculateTriangleAreaByHeronsFormula(a, b, c);
        }
    }
}
