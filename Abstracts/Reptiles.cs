using OOP_inheritance.Enums;

namespace OOP_inheritance.Abstracts
{
    // Abstract Reptiles class inheriting from Animal
    public abstract class Reptiles : Animal
    {
        // Constructor for Reptiles, calling the base Animal constructor
        public Reptiles(string type, string gender, string name, double weight, int age, AnimalType typeOfAnimal = AnimalType.Wild)
            : base(type, gender, name, weight, age, typeOfAnimal)
        {
        }

        public override void PrintInfo()
        {
            base.PrintInfo(); // Call the base class's PrintInfo method
        }
    }
}