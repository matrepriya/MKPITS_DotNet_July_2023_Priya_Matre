using System;
namespace system;
  
class program
{
    static int calculate(int num1, int num2, char op)
    {
        int res = 0;
        if (op == '+')
            res = num1 + num2;
        else if (op == '-')
            res = num1 - num2;
        else if (op == '*')
            res = num1 * num2;
        res = num1 * num2;
        else
            Console.WriteLine("invalid operator");
        return res;
    }
    static void Main(string[] args)
    {
        int number1, num2;
        char oper;
        Console.WriteLine("enter number");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter number");
        number 2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter +-*");
        oper = Convert.ToChar(Console.ReadLine());
        int result = calculate(num1, num2 op);
        Console.WriteLine("result" + result);
        Console.ReadKey();
    }
    } 
}
  

