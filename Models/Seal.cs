using OOP_inheritance.Abstracts;
using OOP_inheritance.Enums;

namespace OOP_inheritance.Models
{       // Seal class inherits from Mammals
    public class Seal : Mammals
    {
        private string _color { get; set; } // Color of the seal

        public Seal(string type = "Harbor seal", string gender = "Female", string name = "Bubbles", double weight = 150, int age = 10, string color = "Silver", AnimalType typOfAnimal = AnimalType.Wild)
            : base(type, gender, name, weight, age, typOfAnimal)
        {
            _color = color; // Set the seal's color
        }

        // Override PrintInfo to include seal-specific information
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Color: {_color}");
        }

        public override void Move()
        {
            Console.WriteLine($"The {Type} {Name} is clumpsy on land.");
            Swim(); // Call the Swim method to describe swimming behavior
        }

        public void Eat(FoodType foodType)
        {
            Console.WriteLine($"The {Type} {Name} is eating {foodType}.");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} is in water and an incredibly efficient swimmer.");
        }
    }
}