// Programmer:   Johannes Brannelid
// Institute:    Chas Academy
// Program:      Fullstack .NET 2024
// Course:       Programmering med C# och .NET
// Lab 6:        OOP Arv

using OOP_inheritance.Enums;
using OOP_inheritance.Interfaces;
using OOP_inheritance.Models;
using OOP_inheritance.Models.ChildClass;

namespace OOP_Inheritance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // New generic List<T> for animals
            List<ICreature> creatures = new List<ICreature>();

            // Add creature to animals List and initialize a value
            creatures.Add(new Person("Female", "Linnea", 24, AnimalType.Domestic));
            creatures.Add(item: new Seal("Walrus", "Female", "Wally", 200, 6, "Brown", AnimalType.Wild));
            creatures.Add(new Giraffe(type: "Giraffe", "Male", "Goofy", 800, 4, 450, AnimalType.Wild));

            // Add default animalt for testing based on the constructor of the class
            creatures.Add(new Lion()); // Add default Lion
            creatures.Add(new SnowLeopard()); // Add default Snow Leopard
            creatures.Add(new Leopard()); // Add default Leopard

            // Call the method to display info
            DisplayInfo(creatures);

            Console.ReadKey();
        }

        // Display information about each creatures and specifik actions base on the type of creature
        public static void DisplayInfo(List<ICreature> creatures)
        {
            // Let Lion, Giraffe, Seal do a specifik actions
            // Call foodtype collect from enum Foodtype and initilized in specific class
            foreach (ICreature animal in creatures)
            {
                animal.MakeSound(); // Let every animal make a sound

                switch (animal)
                {
                    case Lion lion:
                        lion.ShowSpeed();
                        lion.Eat(); // default is meat
                        break;

                    case Giraffe giraffe:
                        giraffe.FindFood();
                        giraffe.Eat(); // default is leaves
                        break;

                    case Seal seal:
                        seal.Eat(); // default is fish
                        seal.Move();
                        break;

                    case Person person:
                        person.Eat(); // default is unknown
                        break;
                }
                Console.WriteLine(); // New line for better console readability
            }
        }
    }
}