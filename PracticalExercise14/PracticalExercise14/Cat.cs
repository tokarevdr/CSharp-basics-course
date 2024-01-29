using System;

namespace PracticalExercise14
{
    internal class Cat : Animal
    {
        public override string Species { get ; set; }

        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
}
