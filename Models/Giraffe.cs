using OOP_inheritance.Abstracts;
using OOP_inheritance.Enums;

namespace OOP_inheritance.Models
{
    public class Giraffe : Mammals
    {
        private readonly int _height;

        public Giraffe(string type = "Giraffe", string gender = "Female", string name = "Sky", double weight = 800, int age = 3, int height = 430, AnimalType typOfAnimal = AnimalType.Wild)
            : base(type, gender, name, weight, age, typOfAnimal)
        {
            _height = height;
        }

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

        public void Eat(FoodType foodType)
        {
            Console.WriteLine($"The giraffe {Name} is eating {foodType}.");
        }

        public void FindFood()
        {
            Console.WriteLine($"The giraffe {Name} with height of {_height}cm is looking for food far up in the tree crowns.");
        }
    }
}