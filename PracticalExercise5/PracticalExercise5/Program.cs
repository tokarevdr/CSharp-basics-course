using System;

namespace PracticalExercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 7;
            int[] array = new int[n];
            float sum = 0;

            Console.WriteLine("Введите значения массива:");

            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int val in array)
            {
                sum += val;
            }

            Console.WriteLine();
            Console.WriteLine($"Среднее арифметическое значение элементов массива = {sum / n}");

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
