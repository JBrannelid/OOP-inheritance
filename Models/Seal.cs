using OOP_inheritance.Abstracts;
using OOP_inheritance.Enums;

namespace OOP_inheritance.Models
{       // Seal class inherits from Mammals
    public class Seal : Mammals
    {
        public string Color { get; set; } // Color of the seal

        public Seal(string type, string gender, string name, double weight, int age, string color, AnimalType typeOfAnimal)
            : base(type, gender, name, weight, age, typeOfAnimal)
        {
            Color = color; // Set the seal's color
        }

        // Override constructor with default values for safty of the program
        public Seal() : this("Harbor Seal", "Female", "Bubbles", 150, 10, "Silver", AnimalType.Wild)
        {
        }

        // Override PrintInfo to include seal-specific information
        public override void PrintInfo()
        {
            base.PrintInfo(); // Call the PrintInfo method from the base class
            Console.WriteLine($"Color: {Color}");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"The {Type} {Name} barks.");
        }

        public override void Move()
        {
            Console.WriteLine($"The {Type} {Name} is clumpsy on land.");
            Swim(); // Call the Swim method to describe swimming behavior
        }

        public override void Eat()
        {
            Console.WriteLine($"The {Type} {Name} is eating {FoodType.fish}.");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} is in water and an incredibly efficient swimmer.");
        }
    }
}