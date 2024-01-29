using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение без знаков препинания:");
            string[] textArray = Console.ReadLine().Split();

            Console.WriteLine();

            string inputText = String.Join("", textArray);
            string reversedText = "";

            foreach (char c in inputText)
            {
                reversedText = c + reversedText;
            }

            if (inputText.ToLower().Equals(reversedText.ToLower()))
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Строка НЕ является палиндромом");
            }

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
