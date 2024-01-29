using System;

namespace PracticalExercise14
{
    internal class Dog : Animal
    {
        public override string Species { get; set; }

        public override void Say()
        {
            Console.WriteLine("Гав"); ;
        }
    }
}
