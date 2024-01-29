using System;
using System.Threading;

namespace PracticalExercise21
{
    internal class Program
    {
        const int n = 10;
        const int m = 10;

        const char firstGardenerSign = 'x';
        const char secondGardenerSign = 'o';

        static int[,] landSectionsCultivationSpeed = new int[n, m];
        static char[,] cultivatedLand = new char[n, m];

        delegate void CultivationHandler();
        static event CultivationHandler Notify;

        static void Main(string[] args)
        {
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    landSectionsCultivationSpeed[i, j] = rand.Next(100, 1000);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    cultivatedLand[i, j] = ' ';
                }
            }

            Notify = PrintCultivatedLand;

            ThreadStart threadStart1 = new ThreadStart(FirstGardenerStart);

            Thread thread1 = new Thread(threadStart1);

            thread1.Start();

            ThreadStart threadStart2 = new ThreadStart(SecondGardenerStart);

            Thread thread2 = new Thread(threadStart2);

            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void FirstGardenerStart()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (cultivatedLand[i, j] != secondGardenerSign)
                    {
                        cultivatedLand[i, j] = firstGardenerSign;

                        Thread.Sleep(landSectionsCultivationSpeed[i, j]);

                        Notify?.Invoke();
                    }
                }
            }
        }

        static void SecondGardenerStart()
        {
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = m - 1; j >= 0; j--)
                {
                    if (cultivatedLand[i, j] != firstGardenerSign)
                    {
                        cultivatedLand[i, j] = secondGardenerSign;

                        Thread.Sleep(landSectionsCultivationSpeed[i, j]);

                        Notify?.Invoke();
                    }
                }
            }
        }

        static void PrintCultivatedLand()
        {
            Console.Clear();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(cultivatedLand[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
