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
            creatures.Add(new Person("Male", "Carl", 24, AnimalType.Domestic));
            creatures.Add(new Lion("African Lion", "Male", "Leon", 190, 5, 50, AnimalType.Wild));
            creatures.Add(new Leopard("Leopard", "Male", "Leonardo", 90, 3, 50, AnimalType.Wild));
            creatures.Add(new SnowLeopard("Snow Leopard", "Male", "John-Snow", 50, 7, 10, AnimalType.Wild));
            creatures.Add(new Giraffe("Giraffe", "Female", "Giraffiii", 800, 4, 430, AnimalType.Wild));
            creatures.Add(new Seal("Harbor Seal", "Female", "Sia", 150, 6, "Silver", AnimalType.Domestic));

            // Call the method to display info
            DisplayInfo(creatures);

            Console.ReadKey();
        }

        // Display information about each creatures and specifik actions base on the type of creature
        public static void DisplayInfo(List<ICreature> creatures)
        {
            foreach (ICreature animal in creatures)
            {
                animal.MakeSound();

                // Let Lion, Giraffe, Seal and person eat and do a specifik actions
                if (animal is Lion lion)
                {
                    lion.ShowSpeed();
                    lion.Eat(FoodType.meat); // Call enum Foodtype and the type of food for Lions
                }
                else if (animal is Giraffe giraffe)
                {
                    giraffe.FindFood();
                    giraffe.Eat(FoodType.leaves); // Giraffe food type
                }
                else if (animal is Seal seal)
                {
                    seal.Eat(FoodType.fish); // Seal food type
                    seal.Move();
                }
                else if (animal is Person person)
                {
                    person.Eat(); // person food type
                }
                Console.WriteLine();  // New line for better console readability 
            }
        }
    }
}