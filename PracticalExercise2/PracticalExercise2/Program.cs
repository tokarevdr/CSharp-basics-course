using System;

namespace PracticalExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение длины окружности:");
            double circleLength = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Радиус окружности = {0}", FindCircleRadiusByLength(circleLength));
            Console.WriteLine("Площадь круга = {0}", CalculateCircleAreaByLength(circleLength));
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }

        static double FindCircleRadiusByLength(double length)
        {
            return length / (2 * Math.PI);
        }

        static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        static double CalculateCircleAreaByLength(double length)
        {
            return CalculateCircleArea(FindCircleRadiusByLength(length));
        }
    }
}
