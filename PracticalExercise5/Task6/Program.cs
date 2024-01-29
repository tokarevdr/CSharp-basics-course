using System;
using System.Data;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");

            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int[,] array = new int[N, N];

            Console.WriteLine("Заполните массив числами:");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"[{i},{j}] ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }
            }

            int magicalConst = N * (N * N + 1) / 2;
            bool isMagical = true;

            int rowSum = 0;
            int colSum = 0;
            int diagSum1 = 0;
            int diagSum2 = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    rowSum += array[i, j];
                    colSum += array[j, i];

                    if (i == j)
                        diagSum1 += array[i, j];

                    if (i + j == N-1)
                        diagSum2 += array[i, j];
                }

                if (rowSum != magicalConst || colSum != magicalConst)
                {
                    isMagical = false;
                    break;
                }

                rowSum = 0;
                colSum = 0;
            }

            if (diagSum1 != magicalConst || diagSum2 != magicalConst)
            {
                isMagical = false;
            }

            if (isMagical)
                Console.WriteLine("Матрица является магическим квадратом");
            else
                Console.WriteLine("Матрица НЕ является магическим квадратом");

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
