using OOP_inheritance.Enums;

namespace OOP_inheritance.Interfaces
{
    // Interface representing a creature with basic properties and behaviors
    // Ensuring that all classes adhere to a common contract for properties and methods
    public interface ICreature
    {
        string Gender { get; set; }
        string Name { get; set; }
        int Age { get; set; }
        AnimalType TypeOfAnimal { get; set; }

        void PrintInfo();

        void MakeSound();

        void Move();

        void Eat();
    }
}