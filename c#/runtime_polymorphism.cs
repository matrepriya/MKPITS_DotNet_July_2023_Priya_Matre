using System;
public class Animal
{
    public virtual void eat()
    {
        Console.WriteLine("Eating");
    }
}
public class Dog : Animal
{
    public override void eat()
    {
        Console.WriteLine("Eating bread");
    }
}
public class Testpolymorphism
{
    public static void Main()
    {
        Animal a = new Dog();
        a.eat();
        Console.ReadKey();
    }
}
