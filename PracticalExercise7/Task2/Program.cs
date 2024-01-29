using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение стороны куба:");
            int a = Convert.ToInt32(Console.ReadLine());

            int S, V;

            CalcCubeAreaAndVolume(a, out S, out V);
            
            Console.WriteLine();

            Console.WriteLine($"Площадь поверхности куба: {S}\nОбъем куба: {V}");

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void CalcCubeAreaAndVolume(int a, out int S, out int V)
        {
            S = 6 * a * a;
            V = a * a * a;
        }
    }
}
