using System;
using System.Collections.Generic;

namespace PracticalExercise18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите выражение, содержащее парные скобки (), {} и []:");
            string input = Console.ReadLine();
            
            Console.WriteLine();

            if (IsBracketsMatched(input))
            {
                Console.WriteLine("Строка введена корректно");
            }
            else
            {
                Console.WriteLine("Строка введена некорректно");
            }

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }

        static bool IsBracketsMatched(string input)
        {
            Stack<char> brackets = new Stack<char>();

            Dictionary<char, char> matchedBrackets = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            foreach (char c in input)
            {
                if (matchedBrackets.ContainsKey(c))
                    brackets.Push(matchedBrackets[c]);

                if (matchedBrackets.ContainsValue(c))
                {
                    if (brackets.Count == 0 || c != brackets.Pop())
                        return false;
                }
            }

            if (brackets.Count != 0)
                return false;

            return true;
        }
    }
}
