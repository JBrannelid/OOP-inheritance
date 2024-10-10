using OOP_inheritance.Abstracts;
using OOP_inheritance.Enums;

namespace OOP_inheritance.Models
{   // Class representing a Lion, inheriting from Mammals
    public class Lion : Mammals
    {    // Property to store the speed of the lion
        public int Speed { get; private set; }

        public Lion(string type, string gender, string name, double weight, int age, int speed, AnimalType typeOfAnimal)
            : base(type, gender, name, weight, age, typeOfAnimal)
        {
            Speed = speed; // Set the lion's speed
        }

        // Override PrintInfo to include Lion-specific information
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Speed: {Speed}");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"The lion {Name} roars loudly!!.");
        }

        public override void Move()
        {
            Console.WriteLine($"The lion {Name} prowls through the grass, stalking its prey.");
        }

        public void Eat(FoodType foodType)
        {
            Console.WriteLine($"The lion {Name} is eating {foodType}.");
        }

        public virtual void ShowSpeed()
        {
            Console.WriteLine($"The lion {Name} is running {Speed} km/h. Hunting its prey");
        }
    }
}