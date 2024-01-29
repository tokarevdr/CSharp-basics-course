using System;

namespace PracticalExercise15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression();
            arithProgression.SetStart(1);
            arithProgression.SetStep(10);

            GeomProgression geomProgression = new GeomProgression();
            geomProgression.SetStart(1);
            geomProgression.SetStep(10);

            Console.WriteLine("Арифметическая прогрессия:");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arithProgression.GetNext());

                if (i == 4)
                    arithProgression.Reset();
            }

            Console.WriteLine();

            Console.WriteLine("Геометрическая прогрессия:");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(geomProgression.GetNext());

                if (i == 6)
                    geomProgression.Reset();
            }
            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую. клавишу...");
            Console.ReadKey();
        }
    }
}
