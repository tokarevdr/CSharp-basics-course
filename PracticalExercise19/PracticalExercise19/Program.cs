using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalExercise19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>
            {
                new Computer(){ Model = "101 HP", CPU = "Intel i3", CpuClockRate = 1.8f, RAM = 4, HDD = 256, VRAM = 2, Price = 15600, InStockCount = 23 },
                new Computer(){ Model = "6 Asus", CPU = "Intel i9", CpuClockRate = 3.7f, RAM = 32, HDD = 1024, VRAM = 12, Price = 156000, InStockCount = 8 },
                new Computer(){ Model = "3 Honor", CPU = "Intel i3", CpuClockRate = 1.8f, RAM = 4, HDD = 256, VRAM = 2, Price = 22000, InStockCount = 32 },
                new Computer(){ Model = "225 Acer", CPU = "Intel i5", CpuClockRate = 2.2f, RAM = 8, HDD = 512, VRAM = 4, Price = 48000, InStockCount = 56 },
                new Computer(){ Model = "38 Msi", CPU = "Ryzen 5", CpuClockRate = 2.5f, RAM = 8, HDD = 512, VRAM = 4, Price = 50000, InStockCount = 67 },
                new Computer(){ Model = "112 Asus", CPU = "Intel i7", CpuClockRate = 2.1f, RAM = 16, HDD = 512, VRAM = 4, Price = 65000, InStockCount = 48 },
                new Computer(){ Model = "15 HP", CPU = "Ryzen 7", CpuClockRate = 3.4f, RAM = 16, HDD = 1024, VRAM = 8, Price = 125000, InStockCount = 45 },
                new Computer(){ Model = "95 Lenovo", CPU = "Intel i5", CpuClockRate = 2.2f, RAM = 8, HDD = 512, VRAM = 4, Price = 45000, InStockCount = 51 }
            };

            PrintComputers(computers);

            Console.WriteLine("Введите название процессора:");
            string cpu = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Компьютеры с указанным процессором:");
            Console.WriteLine();

            PrintComputers(computers.Where(x => x.CPU == cpu));

            Console.WriteLine("Введите требуемый объем ОЗУ:");
            uint ram = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Компьютеры с объемом ОЗУ не ниже указанного:");
            Console.WriteLine();

            PrintComputers(computers.Where(x => x.RAM >= ram));

            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Компьютеры, отсортированные по стоимости:");
            Console.WriteLine();

            PrintComputers(computers.OrderBy(x => x.Price));

            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Компьютеры, сгруппированные по типу процессора:");
            Console.WriteLine();

            IEnumerable<IGrouping<string, Computer>> computersGroupedByCPU = computers.GroupBy(x => x.CPU);

            foreach (var computer in computersGroupedByCPU)
            {
                Console.WriteLine($"{computer.Key}:");
                PrintComputers(computer.AsEnumerable());
            }

            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Самый дорогой компьютер:");
            Console.WriteLine(computers.OrderByDescending(x => x.Price).First().ToString());
            Console.WriteLine();

            Console.WriteLine("Самый дешевый компьютер:");
            Console.WriteLine(computers.OrderBy(x => x.Price).First().ToString());
            Console.WriteLine();

            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Остались ли компютеры в количестве больше 30 штук?");
            Console.WriteLine(computers.Any(x => x.InStockCount >= 30) ? "Да" : "Нет");

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void PrintComputers(IEnumerable<Computer> computers)
        {
            foreach (var computer in computers)
            {
                Console.WriteLine(computer.ToString());
                Console.WriteLine();
            }
        }
    }
}
