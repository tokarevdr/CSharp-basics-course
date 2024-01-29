using System;

namespace PracticalExercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Введите стороны второго треугольника:");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (CalcTriangleArea(a1, b1, c1) > CalcTriangleArea(a2, b2, c2))
                Console.WriteLine("Площадь первого треугольника больше");
            else
                Console.WriteLine("Площадь второго треугольника больше");

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }

        static double CalcTriangleArea(int a, int b, int c)
        {
            int p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
