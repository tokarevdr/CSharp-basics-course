using System;
using PracticalExercise16;
using System.Text.Json;
using System.IO;

namespace ReadJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string fileName = "../../../Products.json";

                Console.WriteLine("Десериализация файла " + fileName);
                Console.WriteLine();

                string jsonString = File.ReadAllText(fileName);

                Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);

                int highestPriceProductIndex = 0;

                for (int i = 1; i < products.Length; i++)
                {
                    if (products[i].Price > products[highestPriceProductIndex].Price)
                    {
                        highestPriceProductIndex = i;
                    }
                }

                Console.WriteLine("Товар с самой высокой ценой:");
                Console.WriteLine(products[highestPriceProductIndex].ToString());
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
