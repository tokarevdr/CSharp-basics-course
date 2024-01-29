using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalExercise20
{
    internal class Program
    {
        public delegate double MyDelegate(double arg);

        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное вещественное значение радиуса");
            Console.Write("R = ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            MyDelegate myDelegate = GetCircleLength;

            Console.WriteLine($"Длина окружности: {myDelegate(r):g3}");

            myDelegate = GetCircleArea;

            Console.WriteLine($"Площадь окружности: {myDelegate(r):g3}");

            myDelegate = GetSphereVolume;

            Console.WriteLine($"Объем сферы: {myDelegate(r):g3}");

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }

        static double GetCircleLength(double R)
        {
            return 2 * Math.PI * R;
        }

        static double GetCircleArea(double R)
        {
            return Math.PI * R * R;
        }

        static double GetSphereVolume(double R)
        {
            return 4.0 / 3.0 * Math.PI * R * R * R;
        }
    }
}
