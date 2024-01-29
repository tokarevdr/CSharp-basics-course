using System;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");

            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int[,] array = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = (i + j) % 2 == 0 ? 1 : 0;
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{array[i, j], 2}");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
