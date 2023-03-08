using System;

public abstract class Animal
{
    public string Name { get; private set; }

    public Animal()
    {
        Name = "Lukas";
    }

    public Animal(string name)
    {
        Name = name;
    }

    public abstract void Move();

    public void Sleep()
    {
        Console.WriteLine($"{Name} est endormi.");
    }
}

public class Dragon : Animal
{
    public Dragon() : base()
    {
    }

    public Dragon(string name) : base(name)
    {
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} vole dans les airs.");
    }
}

public class Griffin : Animal
{
    public Griffin() : base()
    {
    }

    public Griffin(string name) : base(name)
    {
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} s'envole .");
    }
}