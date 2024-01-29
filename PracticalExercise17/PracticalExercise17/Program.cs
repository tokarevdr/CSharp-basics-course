using System;

namespace PracticalExercise17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввод данных счета\n");

            BankAccount<uint> bankAccountInt = new BankAccount<uint>();
            BankAccount<string> bankAccountStr = new BankAccount<string>();

            try
            {
                Console.WriteLine("Счет 1");
                Console.Write("Целочисленный номер: ");
                bankAccountInt.Id = Convert.ToUInt32(Console.ReadLine());

                Console.Write("Баланс: ");
                bankAccountInt.Balance = Convert.ToDouble(Console.ReadLine());

                Console.Write("ФИО: ");
                bankAccountInt.Name = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("Счет 2");
                Console.Write("Строковый номер: ");
                bankAccountStr.Id = Console.ReadLine();

                Console.Write("Баланс: ");
                bankAccountStr.Balance = Convert.ToDouble(Console.ReadLine());

                Console.Write("ФИО: ");
                bankAccountStr.Name = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine(bankAccountInt.ToString());
                Console.WriteLine();
                Console.WriteLine(bankAccountStr.ToString());
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
