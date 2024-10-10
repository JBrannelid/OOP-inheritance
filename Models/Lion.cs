using OOP_inheritance.Abstracts;
using OOP_inheritance.Enums;
using OOP_inheritance.Interfaces;

namespace OOP_inheritance.Models
{   // Class representing a Lion, inheriting from Mammals
    public class Lion : Mammals, ICreature
    {    // Property to store the speed of the lion
        public int Speed { get; private set; }

        // Main constructor
        public Lion(string type, string gender, string name, double weight, int age, int speed, AnimalType typeOfAnimal)
            : base(type, gender, name, weight, age, typeOfAnimal)
        {
            Speed = speed;
        }

        // Override constructor with default values for safty of the program
        public Lion() : this("African Lion", "Male", "Leon", 190, 5, 50, AnimalType.Wild)
        {
        }

        // Override PrintInfo to include Lion-specific information
        public override void PrintInfo()
        {
            base.PrintInfo(); // Call the PrintInfo method from the base class
            Console.WriteLine($"Speed: {Speed}");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"The {Type} {Name} roars loudly!!.");
        }

        public override void Move()
        {
            Console.WriteLine($"The {Type} {Name} prowls through the grass, stalking its prey.");
        }

        public override void Eat()
        {
            Console.WriteLine($"The {Type} {Name} is eating {FoodType.meat}.");
        }

        public virtual void ShowSpeed()
        {
            Console.WriteLine($"The {Type} {Name} is running {Speed} km/h. Hunting its prey");
        }
    }
}