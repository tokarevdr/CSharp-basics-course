using System;

namespace AgeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целочисленное значение возраста (в диапазоне от 20 до 69 лет):");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 20 || age > 69)
            {
                Console.WriteLine("Введено некорректное значение возраста!");

                Console.WriteLine();
                Console.WriteLine("Для продолжения нажмите любую клавишу...");
                Console.ReadKey();
                return;
            }

            int secondDigit = age / 10;
            int firstDigit = age % 10;

            Console.WriteLine(ConvertSecondDigitToString(secondDigit) + ConvertFirstDigitToString(firstDigit) +
                            GetAgeEndingByFirstDigit(firstDigit));

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }

        static string ConvertSecondDigitToString(int digit)
        {
            switch (digit)
            {
                case 2:
                    return "двадцать";

                case 3:
                    return "тридцать";

                case 4:
                    return "сорок";

                case 5:
                    return "пятьдесят";

                case 6:
                    return "шестьдесят";

                default:
                    return "некорректная цифра";
            }
        }

        static string ConvertFirstDigitToString(int digit)
        {
            switch (digit)
            {
                case 0:
                    return "";

                case 1:
                    return " один";

                case 2:
                    return " два";

                case 3:
                    return " три";

                case 4:
                    return " четыре";

                case 5:
                    return " пять";

                case 6:
                    return " шесть";

                case 7:
                    return " семь";

                case 8:
                    return " восемь";

                case 9:
                    return " девять";

                default:
                    return "некорректная цифра";
            }
        }

        static string GetAgeEndingByFirstDigit(int digit)
        {
            switch (digit)
            {
                case 0:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    return " лет";

                case 1:
                    return " год";

                case 2:
                case 3:
                case 4:
                    return " года";

                default:
                    return "некорректная цифра";
            }
        }
    }
}
