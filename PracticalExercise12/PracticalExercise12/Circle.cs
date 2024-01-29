using System;

namespace PracticalExercise12
{
    internal static class Circle
    {
        public static double FindLength(uint radius)
        {
            return 2 * Math.PI * radius;
        }

        public static double FindArea(uint radius)
        {
            return Math.PI * radius * radius;
        }

        public static bool IsInside(double x, double y, uint radius, double x0, double y0)
        {
            return Math.Sqrt(Math.Pow((x - x0), 2) + Math.Pow((y - y0), 2)) <= radius;
        }
    }
}
