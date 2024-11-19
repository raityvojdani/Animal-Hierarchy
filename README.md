# Animal Hierarchy Project

This project demonstrates a hierarchy of animal classes in C# using **Inheritance**, **Polymorphism**, and **Generics with Variance**. The `Animal_Hierarchy` namespace provides a flexible structure for creating and interacting with various animal types, showcasing concepts like method overriding, covariance, and contravariance.

---

## Features

1. **Class Hierarchy:**
   - **Base Class:** `Animal`  
   - **Derived Classes:** `Mammal`, `Bird`, `Fish`
   - **Specific Implementations:** `Dog`, `Eagle`, `Shark`

2. **Interfaces:**
   - `ICovariant<T>`: Demonstrates covariance.
   - `IContravariant<T>`: Demonstrates contravariance.

3. **Polymorphism:**
   - Overriding methods like `MakeSound`, `Eat`, and `Fly` in derived classes.

4. **Generics with Variance:**
   - Using generic interfaces for handling animal objects with covariance and contravariance.

---

## Code Overview

### Class Design

- **Animal (Base Class):**
  ```csharp
  public class Animal
  {
      public string Name { get; set; }
      public int Age { get; set; }
      public virtual void Eat() => Console.WriteLine($"{Name} is eating.");
      public virtual void Sleep() => Console.WriteLine($"{Name} is sleeping.");
      public virtual void MakeSound() => Console.WriteLine($"{Name} makes a sound.");
  }

### Example Usage
 ```csharp
Animal dog = new Dog { Name = "Buddy", Age = 3, WarmBlooded = true };
Animal eagle = new Eagle { Name = "Sky", Age = 5 };
Animal shark = new Shark { Name = "Locy", Age = 8, CanSwim = true };

dog.MakeSound();  // Output: Buddy barks.
eagle.MakeSound(); // Output: Sky makes a sound.
shark.Eat();       // Output: Locy is eating fish.

// Covariance Example
AnimalHandler<Dog> dogHandler = new AnimalHandler<Dog>();
dogHandler.SetAnimal(new Dog { Name = "Buddy", Age = 3, WarmBlooded = true });
ICovariant<Animal> animalCovariant = dogHandler;
Console.WriteLine(animalCovariant.GetAnimal()?.Name); // Output: Buddy
