using OOP_inheritance.Enums;
using OOP_inheritance.Interfaces;

namespace OOP_inheritance.Abstracts
{
    // Abstract class representing a human, implementing the ICreature interface
    public abstract class Human : ICreature
    {
        // Fields representing the characteristics of a human
        public string Gender { get; set; } 

        public string Name { get; set; }
        public int Age { get; set; } 
        public AnimalType TypeOfAnimal { get; set; } = AnimalType.Wild;

        // Constructor to initialize human properties
        protected Human(string gender, string name, int age, AnimalType typeOfAnimal)
        {
            Gender = gender;
            Name = name;
            Age = age;
            TypeOfAnimal = typeOfAnimal;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Age: {Age} years");
            Console.WriteLine($"Animal Type: {TypeOfAnimal}");
        }

        public abstract void MakeSound();

        public abstract void Move();

        public virtual void Eat(FoodType foodType = FoodType.unknown)
        {
            Console.WriteLine($"{Name} is eating {foodType}.");
        }
    }
}