using System;

namespace TaskDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            int negativeCount = 0;
            int positiveCount = 0;

            do
            {
                Console.WriteLine("Введите целое число (или 0 для завершения ввода):");
                value = Convert.ToInt32(Console.ReadLine());

                if (value > 0) positiveCount++;
                if (value < 0) negativeCount++;

            } while (value != 0);

            if (positiveCount > negativeCount)
            {
                Console.WriteLine("Положительных чисел больше, чем отрицательных.");
            }
            else if (negativeCount > positiveCount)
            {
                Console.WriteLine("Отрицательных чисел больше, чем положительных.");
            }
            else
            {
                Console.WriteLine("Количество положительных и отрицательных чисел равно.");
            }

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
