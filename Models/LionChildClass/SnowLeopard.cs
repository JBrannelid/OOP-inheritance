using OOP_inheritance.Enums;

namespace OOP_inheritance.Models.ChildClass
{
    public class SnowLeopard : Lion
    {
        public SnowLeopard(string type, string gender, string name, double weight, int age, int speed, AnimalType typeOfAnimal)
            : base(type, gender, name, weight, age, speed, typeOfAnimal)
        {
        }
        // Override constructor with default values for safty of the program
        public SnowLeopard() : this("Snow Leopard", "Male", "John-Snow", 50, 7, 10, AnimalType.Wild)
        { }

        public override void MakeSound()
        {
            Console.WriteLine($"The SnowLeopard {Name} roars!!.");
        }

        public override void Move()
        {
            Console.WriteLine($"The SnowLeopard {Name} is hunting.");
        }

        public new void Eat(FoodType foodType = FoodType.meat)
        {
            Console.WriteLine($"The SnowLeopard {Name} is eating {foodType}.");
        }

        public override void ShowSpeed()
        {
            Console.WriteLine($"The SnowLeopard {Name} is running at {Speed}km/h");
        }
    }
}