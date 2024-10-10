using OOP_inheritance.Enums;
using OOP_inheritance.Interfaces;

namespace OOP_inheritance.Abstracts
{
    // Abstract class representing a Animal, implementing the ICreature interface
    public abstract class Animal : ICreature
    {    // Fields representing the characteristics of a Animal
        public string Type { get; }
        public string Gender { get; set; }
        public string Name { get; set; }
        public double Weight { get; }
        public int Age { get; set; }
        public AnimalType TypeOfAnimal { get; set; }

        // Constructor to initialize Animal properties
        public Animal(string type, string gender, string name, double weight, int age, AnimalType typeOfAnimal)
        {
            Type = type;
            Gender = gender;
            Name = name;
            Weight = weight;
            Age = age;
            TypeOfAnimal = typeOfAnimal;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Age: {Age} years");
            Console.WriteLine($"Animal Type: {TypeOfAnimal}");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} is making a sound.");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name} is moving.");
        }

        void ICreature.Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }
    }
}