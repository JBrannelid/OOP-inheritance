using OOP_inheritance.Enums;

namespace OOP_inheritance.Models.ChildClass
{
    public class SnowLeopard : Lion
    {
        public SnowLeopard(string type = "Snow Leopard", string gender = "Male", string name = "Tian", double weight = 50, int age = 7, int speed = 10, AnimalType typOfAnimal = AnimalType.Wild)
            : base(type, gender, name, weight, age, speed, typOfAnimal)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"The SnowLeopard {Name} roars!!.");
        }

        public override void Move()
        {
            Console.WriteLine($"The SnowLeopard {Name} is hunting.");
        }

        public new void Eat(FoodType foodType)
        {
            Console.WriteLine($"The SnowLeopard {Name} is eating {foodType}.");
        }

        public override void ShowSpeed()
        {
            Console.WriteLine($"The SnowLeopard {Name} is running at {Speed}km/h");
        }
    }
}