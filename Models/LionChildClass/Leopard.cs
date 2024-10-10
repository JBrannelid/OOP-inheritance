using OOP_inheritance.Enums;

namespace OOP_inheritance.Models.ChildClass
{
    public class Leopard : Lion
    {
        public Leopard(string type, string gender, string name, double weight, int age, int speed, AnimalType typeOfAnimal)
            : base(type, gender, name, weight, age, speed, typeOfAnimal)
        {
        }
        // Override constructor with default values for safty of the program
        public Leopard() : this("Leopard", "Male", "Leonardo", 90, 3, 50, AnimalType.Wild)
        { }
        public override void MakeSound()
        {
            Console.WriteLine($"The {Type} {Name} roars.");
        }

        public override void Move()
        {
            Console.WriteLine($"The {Type} {Name} is hunting.");
        }

        public new void Eat(FoodType foodType = FoodType.meat)
        {
            Console.WriteLine($"The {Type} {Name} is eating {foodType}.");
        }

        public override void ShowSpeed()
        {
            Console.WriteLine($"The {Type} {Name} is running at {Speed}");
        }
    }
}