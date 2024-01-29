using System;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace PracticalExercise16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите информацию о товарах\n");

                int n = 5;

                Product[] products = new Product[n];

                for (int i = 0; i < n; i++)
                {
                    products[i] = new Product();
                    Console.WriteLine($"Товар {i + 1}");
                    Console.Write("Код: ");
                    products[i].Id = Convert.ToUInt32(Console.ReadLine());
                    Console.Write("Название: ");
                    products[i].Name = Console.ReadLine();
                    Console.Write("Цена: ");
                    products[i].Price = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine();
                }

                JsonSerializerOptions options = new JsonSerializerOptions();

                options.Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic);
                options.WriteIndented = true;

                string jsonString = JsonSerializer.Serialize(products, options);
                string fileName = "../../../Products.json";

                File.WriteAllText(fileName, jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! " + ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
