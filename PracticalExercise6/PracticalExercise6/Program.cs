using System;

namespace PracticalExercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение без знаков препинания:");
            string[] textArray = Console.ReadLine().Split();

            string maxWord = textArray[0];

            foreach(string word in textArray)
            {
                if (word.Length > maxWord.Length)
                    maxWord = word;
            }

            Console.WriteLine();
            Console.WriteLine($"Самое длинное слово в предложении - {maxWord}");

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
