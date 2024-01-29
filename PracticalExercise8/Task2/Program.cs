using System;
using System.IO;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Verak\OneDrive\Мага 1 сем\ТокаревДР_Основы программирования на С#\PracticalExercise8\Task2\numbers.txt";

            Random rnd = new Random();

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    writer.WriteLine(Convert.ToString(rnd.Next(0, 25)));
                }
            }

            int sum = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    sum += Convert.ToInt32(reader.ReadLine());
                }
            }

            Console.WriteLine($"Сумма чисел в файле: {sum}");

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
