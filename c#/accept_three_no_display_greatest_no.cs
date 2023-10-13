using System;
namespace ifgreaterthreeno
{
    class program
{
    static void Main(string[]args)
    {
        int num1, num2, num3;
        Console.WriteLine("enter numner 1");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter numner 2");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter numner 3");
        num3 = Convert.ToInt32(Console.ReadLine());
        if (num1 > num2 && num1 > num3)
            Console.WriteLine("num1 is greater");
        else if (num2 > num3)
            Console.WriteLine("num2 is greater");
        else
            Console.WriteLine("num3 is grater)");
        Console.ReadKey();
        }
    }
}

