using System;

namespace NumberTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число (в диапазоне от 100 до 999):");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 100 || number > 999)
            {
                Console.WriteLine("Введено некорректное значение!");

                Console.WriteLine();
                Console.WriteLine("Для продолжения нажмите любую клавишу...");
                Console.ReadKey();
                return;
            }

            int thirdDigit = number / 100;

            int SecondAndFirstDigits = number % 100;

            Console.WriteLine(ConvertThirdDigitToString(thirdDigit) + ConvertTwoDigitNumberToString(SecondAndFirstDigits));

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }

        static string ConvertTwoDigitNumberToString(int number)
        {
            int firstDigit = 0;
            int secondDigit = 0;

            switch (number)
            {
                case 11:
                    return " одиннадцать";
                case 12:
                    return " двенадцать";
                case 13:
                    return " тринадцать";
                case 14:
                    return " четырнадцать";
                case 15:
                    return " пятнадцать";
                case 16:
                    return " шестнадцать";
                case 17:
                    return " семнадцать";
                case 18:
                    return " восемнадцать";
                case 19:
                    return " девятнадцать";
                default:
                    secondDigit = number / 10;
                    firstDigit = number % 10;

                    return ConvertSecondDigitToString(secondDigit) + ConvertFirstDigitToString(firstDigit);
            }
        }

        static string ConvertThirdDigitToString(int digit)
        {
            switch (digit)
            {
                case 1:
                    return "сто";

                case 2:
                    return "двести";

                case 3:
                    return "триста";

                case 4:
                    return "четыреста";

                case 5:
                    return "пятьсот";

                case 6:
                    return "шестьсот";

                case 7:
                    return "семьсот";

                case 8:
                    return "восемьсот";

                case 9:
                    return "девятьсот";

                default:
                    return "некорректная цифра";
            }
        }

        static string ConvertSecondDigitToString(int digit)
        {
            switch (digit)
            {
                case 0:
                    return "";

                case 1:
                    return " десять";

                case 2:
                    return " двадцать";

                case 3:
                    return " тридцать";

                case 4:
                    return " сорок";

                case 5:
                    return " пятьдесят";

                case 6:
                    return " шестьдесят";

                case 7:
                    return " семьдесят";

                case 8:
                    return " восемьдесят";

                case 9:
                    return " девяносто";

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
    }
}
