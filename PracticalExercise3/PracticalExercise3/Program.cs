using System;

namespace PracticalExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты трех вершин прямоугольника:");

            Console.WriteLine("x1 =");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("y1 =");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("x2 =");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("y2 =");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("x3 =");
            int x3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("y3 =");
            int y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            bool isRectangleHasSideParallelToX = true;
            bool isRectangleHasSideParallelToY = true;

            double x4 = 0;
            double y4 = 0;

            if (IsParallelToX(y1, y2))
            {
                if (IsParallelToY(x1, x3))
                {
                    x4 = x2;
                    y4 = y3;
                }
                else if(IsParallelToY(x2, x3))
                {
                    x4 = x1;
                    y4 = y3;
                }
                else
                {
                    isRectangleHasSideParallelToY = false;
                }
            }
            else if (IsParallelToX(y1, y3))
            {
                if (IsParallelToY(x1, x2))
                {
                    x4 = x3;
                    y4 = y2;
                }
                else if (IsParallelToY(x2, x3))
                {
                    x4 = x1;
                    y4 = y2;
                }
                else
                {
                    isRectangleHasSideParallelToY = false;
                }
            }
            else if (IsParallelToX(y2, y3))
            {
                if (IsParallelToY(x1, x2))
                {
                    x4 = x3;
                    y4 = y1;
                }
                else if (IsParallelToY(x1, x3))
                {
                    x4 = x2;
                    y4 = y1;
                }
                else
                {
                    isRectangleHasSideParallelToY = false;
                }
            }
            else
            {
                isRectangleHasSideParallelToX = false;
            }

            if (isRectangleHasSideParallelToX && isRectangleHasSideParallelToY)
            {
                Console.WriteLine($"Координаты четвертой вершины: ({x4}; {y4})");
            }
            else
            {
                Console.WriteLine("Невозможно получить прямоугольник со сторонами, параллельными координатным осям");
            }

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }

        static bool IsParallelToX(int y1, int y2)
        {
            return y1 == y2;
        }

        static bool IsParallelToY(int x1, int x2)
        {
            return x1 == x2;
        }
    }
}
