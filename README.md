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
