using OOP_inheritance.Enums;

namespace OOP_inheritance.Abstracts
{
    // Abstract Mammals class inheriting from Animal
    public abstract class Mammals : Animal
    {
        // Constructor for Mammals, calling the base Animal constructor
        public Mammals(string type, string gender, string name, double weight, int age, AnimalType typeOfAnimal)
            : base(type, gender, name, weight, age, typeOfAnimal)
        {
        }
    }
}