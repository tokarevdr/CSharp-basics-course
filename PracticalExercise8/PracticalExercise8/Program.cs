using System;
using System.IO;

namespace PracticalExercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Verak\OneDrive\Изображения\Saved Pictures";

            if (Directory.Exists(path))
            {
                foreach (string file in Directory.GetFiles(path, "*", SearchOption.AllDirectories))
                {
                    Console.WriteLine(file);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
