using System;

namespace PracticalExercise14
{
    internal abstract class Animal
    {
        public abstract string Species { get; set; }

        public Animal()
        {
            Species = "Животное";
        }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine(Species);
            Say();
        }
    }
}
