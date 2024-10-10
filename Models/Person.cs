using OOP_inheritance.Abstracts;
using OOP_inheritance.Enums;

namespace OOP_inheritance.Models
{
    public class Person : Human
    {
        public Person(string gender = "male", string name = "Carl", int age = 24, AnimalType typeOfAnimal = AnimalType.Domestic)
            : base(gender, name, age, typeOfAnimal)
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

        public void Eat(FoodType foodType)
        {
            Console.WriteLine($"{Name} is eating {foodType}");
        }
    }
}