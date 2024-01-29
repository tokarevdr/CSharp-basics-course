using System;

namespace TaskWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целочисленные значения длин сторон прямоугольника:");
            Console.WriteLine("A =");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B =");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Введите целочисленное значение длины стороы квадрата:");
            Console.WriteLine("C =");
            int C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"На праямоугольнике размера {A}x{B} может быть максимально размещено {CountSquaresInRectangle(A, B, C)} " +
                $"квадратов со стороной {C}");

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }

        static int CountSquaresInRectangle(int rectangleSideA, int rectangleSideB, int squareSide)
        {
            int currentPositionOnSideA = squareSide;
            int currentPositionOnSideB = squareSide;
            int squaresCount = 0;

            while (currentPositionOnSideA <= rectangleSideA)
            {
                while (currentPositionOnSideB <= rectangleSideB)
                {
                    currentPositionOnSideB += squareSide;
                    squaresCount++;
                }

                currentPositionOnSideA += squareSide;

                currentPositionOnSideB = squareSide;
            }

            return squaresCount;
        }
    }
}
