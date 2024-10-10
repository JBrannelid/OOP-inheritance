using OOP_inheritance.Abstracts;
using OOP_inheritance.Enums;

namespace OOP_inheritance.Models
{
    public class Giraffe : Mammals
    {
        private readonly int _height;

        public Giraffe(string type, string gender, string name, double weight, int age, int height, AnimalType typeOfAnimal)
            : base(type, gender, name, weight, age, typeOfAnimal)
        {
            _height = height;
        }

        // Override constructor with default values for safty of the program
        public Giraffe() : this("Giraffe", "Female", "Giraffiii", 800, 4, 430, AnimalType.Wild)
        { }

        public override void PrintInfo()
        {
            base.PrintInfo(); // Call the PrintInfo method from the base class
            Console.WriteLine($"Height: {_height}");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"The {Type} {Name} bleats.");
        }

        public override void Move()
        {
            Console.WriteLine($"The {Type} {Name} is moving.");
        }

        public override void Eat()
        {
            Console.WriteLine($"The {Type} {Name} is eating {FoodType.leaves}.");
        }

        public void FindFood()
        {
            Console.WriteLine($"The {Type} {Name} with height of {_height}cm is looking for food far up in the tree crowns.");
        }
    }
}