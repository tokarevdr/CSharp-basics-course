using System;
using System.Threading;
using System.Threading.Tasks;

namespace PracticalExercise23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число:");
            int n = Convert.ToInt32(Console.ReadLine());

            FactorialAsync(n + 3);
            FactorialAsync(n + 2);
            FactorialAsync(n + 1);
            Factorial(n);

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }

        static int Factorial(int n)
        {
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;

                Thread.Sleep(100);
            }

            Console.WriteLine($"{n}! = {result}");

            return result;
        }

        static async void FactorialAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }
    }
}
