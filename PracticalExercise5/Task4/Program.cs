using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 20;
            int[] array = new int[n];

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-50, 50);
            }

            Console.WriteLine("Исходный массив:");

            foreach (int val in array)
            {
                Console.Write($"{val,4}");
            }

            Console.WriteLine();

            int count = 0;

            for (int i = 1; i < n; i += 2)
            {
                if ((array[i] % 2 == 1) && (array[i] > 0))
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество нечетных положительных элементов, стоящих на четных местах: {count}");

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
