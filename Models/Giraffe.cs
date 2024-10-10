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
            base.PrintInfo();
            Console.WriteLine($"Height: {_height}");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"The giraffe {Name} bleats.");
        }

        public override void Move()
        {
            Console.WriteLine($"The giraffe {Name} is moving.");
        }

        public void Eat(FoodType foodType = FoodType.leaves)
        {
            Console.WriteLine($"The giraffe {Name} is eating {foodType}.");
        }

        public void FindFood()
        {
            Console.WriteLine($"The giraffe {Name} with height of {_height}cm is looking for food far up in the tree crowns.");
        }
    }
}