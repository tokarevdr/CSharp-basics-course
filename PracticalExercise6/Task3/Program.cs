using System;
using System.Linq;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string inputText = Console.ReadLine();

            Console.WriteLine();

            string newText = inputText;

            int[] openCurlyBracketIndexes = { };

            for (int i = 0; i < newText.Length; i++)
            {
                switch (newText[i])
                {
                    case '{':
                        openCurlyBracketIndexes = openCurlyBracketIndexes.Append(i).ToArray();

                        break;

                    case '}':
                        if (openCurlyBracketIndexes.Length != 0)
                        {
                            newText = newText.Remove(openCurlyBracketIndexes.Last(), i - openCurlyBracketIndexes.Last() + 1);

                            openCurlyBracketIndexes = openCurlyBracketIndexes.Take(openCurlyBracketIndexes.Count() - 1).ToArray();
                            i = 0;
                        }

                        break;

                    default: break;
                }
            }

            newText = String.Join(" ", newText.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries));

            Console.WriteLine("Строка без текста, заключенного в фигурные скобки:");
            Console.WriteLine(newText);

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
