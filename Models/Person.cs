using OOP_inheritance.Abstracts;
using OOP_inheritance.Enums;

namespace OOP_inheritance.Models
{
    public class Person : Human
    {
        public Person(string gender, string name, int age, AnimalType typeOfAnimal)
            : base(gender, name, age, typeOfAnimal)
        {
        }

        // Override constructor with default values for safty of the program
        public Person() : this("Male", "Carl", 24, AnimalType.Domestic)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"The {Gender} human {Name} is conversating.");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} is walking forwards on two legs.");
        }

        public void Eat(FoodType foodType = FoodType.unknown)
        {
            Console.WriteLine($"{Name} is eating {foodType}");
        }
    }
}