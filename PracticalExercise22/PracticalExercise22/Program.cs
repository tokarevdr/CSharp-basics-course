using System;
using System.Threading.Tasks;

namespace PracticalExercise22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число:");
            int n = Convert.ToInt32(Console.ReadLine());

            Func<object, int[]> func1 = new Func<object, int[]>(GetArray);
            Task<int[]> task1 = new Task<int[]>(func1, n);

            Func<Task<int[]>, int> func2 = new Func<Task<int[]>, int>(GetSum);
            Task<int> task2 = task1.ContinueWith<int>(func2);

            Func<Task<int[]>, int> func3 = new Func<Task<int[]>, int>(GetMax);
            Task<int> task3 = task1.ContinueWith<int>(func3);

            task1.Start();

            for (int i = 0; i < n; i++)
            {
                Console.Write(task1.Result[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine(task2.Result);
            Console.WriteLine(task3.Result);

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }

        static int[] GetArray(object obj)
        {
            int n = (int)obj;

            Random rand = new Random();

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(10, 100);
            }

            return array;
        }

        static int GetSum(Task<int[]> task)
        {
            int[] array = task.Result;

            int sum = 0;

            foreach (int i in array)
            {
                sum += i;
            }

            return sum;
        }

        static int GetMax(Task<int[]> task)
        {
            int[] array = task.Result;

            int max = array[0];

            foreach (int i in array)
            {
                if (i > max)
                    max = i;
            }

            return max;
        }
    }
}
