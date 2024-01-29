using System;

namespace PracticalExercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Перевод угла в радианы\n");

            try
            {
                Console.WriteLine("Введите целочисленное значения для угла:");
                Console.Write("градусы = ");
                uint deg = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine();

                Console.Write("минуты = ");
                uint min = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine();

                Console.Write("секунды = ");
                uint sec = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine();

                Angle angle = new Angle(deg, min, sec);

                Console.WriteLine($"{angle.Degrees}° {angle.Minutes}' {angle.Seconds}\" = {angle.ToRadians():g3} рад");
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
