using System;

namespace PracticalExercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число:");
            Square(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void Square(int N)
        {
            int sum = 0;

            for (int i = 1; i <= N; i++)
            {
                sum += 2 * i - 1;

                Console.WriteLine(sum);
            }
        }
    }
}
