namespace Animal_Hierarchy;

public class Program
{
    static void Main(string[] args)
    {

        Animal dog = new Dog { Name = "Buddy", Age = 3, WarmBlooded = true };
        //dog.Name = "Buddy";
        //dog.Age = 3;
        //dog.WarmBlooded = true;
        Animal eagle = new Eagle { Name = "Sky", Age = 5 };
        Animal shark = new Shark { Name = "Locy", Age = 8, CanSwim = true };

        dog.MakeSound();
        eagle.MakeSound();
        shark.Eat();

        // Covariance
        AnimalHandler<Dog> dogHandler = new AnimalHandler<Dog>();
        dogHandler.SetAnimal(new Dog { Name = "Buddy", Age = 3, WarmBlooded = true });

        ICovariant<Animal> animalCovariant = dogHandler;
        Console.WriteLine(animalCovariant.GetAnimal()?.Name);

    }
}
public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public virtual void Eat() { Console.WriteLine($"{Name} is eating."); }
    public virtual void Sleep() { Console.WriteLine($"{Name} is sleeping.");}
public virtual void MakeSound() { Console.WriteLine($"{Name} makes a sound."); }

}

public class Mammal : Animal
{
    public bool WarmBlooded { get; set; }
    public override void MakeSound() { Console.WriteLine($"{Name} makes a mammal sound."); }

}
public class Dog : Mammal
{
    public override void MakeSound() { Console.WriteLine($"{Name} barks.");}
}

public class Bird : Animal
{
    public int EggsNumber { get; set; }
    public virtual void Fly() { Console.WriteLine($"{Name} can fly."); }
}


public class Eagle : Bird
{
    public override void Fly() { Console.WriteLine($"{Name} flies high.");}
}


public class Fish : Animal
{
    public bool CanSwim { get; set; }
    public override void MakeSound() { Console.WriteLine($"{Name} makes no sound."); }

}


public class Shark : Fish
{
    public override void Eat()  {Console.WriteLine($"{Name} is eating fish.");}
}


public interface ICovariant<out T>
{
    T GetAnimal();
}

public interface IContravariant<in T>
{
    void SetAnimal(T animal);
}

public class AnimalHandler<T> : ICovariant<T>, IContravariant<T>
{
    private T _animal;

    public T GetAnimal() { return _animal; }
    public void SetAnimal(T animal) { _animal = animal; }

}
