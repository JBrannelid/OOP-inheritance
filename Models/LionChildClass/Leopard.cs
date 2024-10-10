using OOP_inheritance.Enums;

namespace OOP_inheritance.Models.ChildClass
{
    public class Leopard : Lion
    {
        public Leopard(string type = "Jaguar", string gender = "Female", string name = "Leon", double weight = 20, int age = 1, int speed = 0, AnimalType typOfAnimal = AnimalType.Wild)
            : base(type, gender, name, weight, age, speed, typOfAnimal)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"The {Type} {Name} roars.");
        }

        public override void Move()
        {
            Console.WriteLine($"The {Type} {Name} is hunting.");
        }

        public new void Eat(FoodType foodType)
        {
            Console.WriteLine($"The {Type} {Name} is eating {foodType}.");
        }

        public override void ShowSpeed()
        {
            Console.WriteLine($"The {Type} {Name} is running at {Speed}");
        }
    }
}