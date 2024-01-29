using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"../../Text.txt";
            string text = "";

            using (StreamReader reader = new StreamReader(path))
            {
                text = reader.ReadToEnd();
            }

            int symbolsCount = text.Length;
            int linesCount = text.Split('\n').Length;
            int wordsCount = text.Split().Length;

            Console.WriteLine($"Статистика по файлу {path}:");
            Console.WriteLine($"Количество символов: {symbolsCount}");
            Console.WriteLine($"Количество строк: {linesCount}");
            Console.WriteLine($"Количество слов: {wordsCount}");

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
