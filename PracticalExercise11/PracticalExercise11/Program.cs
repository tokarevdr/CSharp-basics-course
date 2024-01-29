using System;

namespace PracticalExercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решить уравнение виде kx + b = 0");
            Console.WriteLine();

            try
            {
                Console.WriteLine("Введите вещественные значения коэффициентов:");
                Console.Write("k = ");
                double k = Convert.ToDouble(Console.ReadLine());

                Console.Write("b = ");
                double b = Convert.ToDouble(Console.ReadLine());

                LinearEquationSolver solver = new LinearEquationSolver(k, b);

                Console.WriteLine();

                Console.WriteLine("x = " + solver.Root());
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
