using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-50, 50);
            }

            Console.WriteLine("Исходный массив:");
            
            foreach (int val in array)
            {
                Console.Write($"{val, 4}");
            }

            Console.WriteLine();

            int temp = 0;

            for (int i = 0; i < n/2; i++)
            {
                for (int j = i; j < n/2; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            for (int i = n/2; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            Console.WriteLine("Отсортированный массив:");

            foreach (int val in array)
            {
                Console.Write($"{val,4}");
            }

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
