using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            int[] array = new int[n];

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 50);
            }

            Console.WriteLine("Исходный массив:");

            foreach (int val in array)
            {
                Console.Write($"{val,4}");
            }

            Console.WriteLine();

            int max = array[0];
            int min = array[0];

            foreach (int val in array)
            {
                if (val > max)
                    max = val;

                if (val < min)
                    min = val;
            }

            Console.WriteLine($"Сумма максимального и минимального элементов = {max + min}");

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
