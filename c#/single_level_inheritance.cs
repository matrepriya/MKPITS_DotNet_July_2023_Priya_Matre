using System;
public class Employee
{
    public float salary = 40000;
}
public class programmer : Employee
{
    public float bonus = 10000;
}
  class TestInheritance
{
    public static void Main(string[]args)
    {
        programmer p1 = new programmer();
        Console.WriteLine("salary:" + p1.salary);
        Console.WriteLine("Bonus:" + p1.bonus);

    }
  }
