# OOP Inheritance 

## Overview

This project demonstrates the principles of Object-Oriented Programming (OOP) using C# and .NET. It includes a hierarchy of animal classes utilizing inheritance, polymorphism, and interfaces to model various creatures and their behaviors.

## Features

- **Animal Hierarchy:** Implements a class structure for different animals, including mammals, reptiles, humans and specific animal types like lions, seals, and giraffes.
- **Polymorphism:** Uses method overriding to allow derived classes to provide specific implementations for shared behaviors such as `MakeSound`, `Move`, and `Eat`.
- **Default Constructors:** Each animal class has default constructors for easy instantiation with common values.
- **Interfaces:** Defines a common interface `ICreature` to standardize properties and behaviors across different creature types.

## Example Usage

Here is an example of how to use the classes in the project:

```csharp
using OOP_inheritance.Enums;
using OOP_inheritance.Interfaces;
using OOP_inheritance.Models;
using OOP_inheritance.Models.ChildClass;

namespace OOP_Inheritance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Create a list of creatures
            List<ICreature> creatures = new List<ICreature>
            {
                new Person("Female", "Linnea", 24, AnimalType.Domestic),
                new Seal("Walrus", "Female", "Wally", 200, 6, "Brown", AnimalType.Wild),
                new Giraffe("Giraffe", "Male", "Goofy", 800, 4, 450, AnimalType.Wild),
                new Lion(), // Default Lion
                new SnowLeopard(), // Default Snow Leopard
                new Leopard() // Default Leopard
            };

            // Display information about each creature
            foreach (var creature in creatures)
            {
                creature.MakeSound(); // Output the sound the creature makes
                creature.Move();      // Output the movement behavior of the creature
                creature.Eat();       // Output the eating behavior of the creature
                Console.WriteLine();  // Add a new line for readability
            }

            Console.ReadKey(); // Wait for a key press to close the console
        }
    }
}


### Prerequisites

- .NET SDK (version 6.0 or later)

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/JBrannelid/OOP-inheritance.git
   cd oop-inheritance-project
