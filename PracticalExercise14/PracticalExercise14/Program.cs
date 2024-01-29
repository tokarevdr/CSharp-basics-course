using System;

namespace PracticalExercise14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Species = "Кошка";

            Dog dog = new Dog();
            dog.Species = "Собака";

            cat.ShowInfo();
            Console.WriteLine();
            dog.ShowInfo();

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую. клваишу...");
            Console.ReadKey();
        }
    }
}
