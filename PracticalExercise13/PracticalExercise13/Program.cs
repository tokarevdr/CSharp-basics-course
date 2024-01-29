using System;

namespace PracticalExercise13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("пр-кт Ленина", 40, 40, 15);

            MultiBuilding multiBuilding = new MultiBuilding("улица Ленина", 150, 40, 70, 15);

            Console.WriteLine(building.Print());
            Console.WriteLine();
            Console.WriteLine(multiBuilding.Print());

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую. клваишу...");
            Console.ReadKey();
        }
    }
}
