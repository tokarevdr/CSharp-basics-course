using System;

namespace PracticalExercise12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите параметры окружности:");
                Console.Write("R = ");
                uint R = Convert.ToUInt32(Console.ReadLine());
                Console.Write("x0 = ");
                double x0 = Convert.ToDouble(Console.ReadLine());
                Console.Write("y0 = ");
                double y0 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите параметры точки:");
                Console.Write("x = ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("y = ");
                double y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine($"Длина окружности: {Circle.FindLength(R):g3}");

                Console.WriteLine($"Площадь круга: {Circle.FindArea(R):g3}");

                Console.Write($"Точка ({x}; {y})");

                if (Circle.IsInside(x, y, R, x0, y0))
                {
                    Console.Write($" принадлежит кругу, ограниченному заданной окружностью\n");
                }
                else
                {
                    Console.Write($" не принадлежит кругу, ограниченному заданной окружностью\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! " + ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
