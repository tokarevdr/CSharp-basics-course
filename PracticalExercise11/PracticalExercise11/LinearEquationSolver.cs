using System;

namespace PracticalExercise11
{
    internal struct LinearEquationSolver
    {
        private double k;
        private double b;

        public LinearEquationSolver(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public string Root()
        {
            if (k == 0)
            {
                if (b == 0)
                {
                    return "бесконечное число решений";
                }
                else
                {
                    return "решений нет";
                }
            }

            return Convert.ToString(-b / k);
        }
    }
}
