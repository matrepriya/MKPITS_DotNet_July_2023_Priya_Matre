using System;
namespace program
{
    class program
    {
        static void Bank(int actno, int amount, int withdrawl, int deposite)
        {
            withdrawl = amount-withdrawl;
            Console.WriteLine("withdrawl:current amount " + withdrawl);
            deposite = amount + deposite;
            Console.WriteLine("deposite: current balance:" + deposite);
        }
        static void Main()
        { 
                int actno;
                Console.WriteLine(" enter actno");
                actno = Convert.ToInt32(Console.ReadLine());
                int amount=0;
                Console.WriteLine("enter amount");
                amount = Convert.ToInt32(Console.ReadLine());
                int withdrawl=0;
                Console.WriteLine("enter withdrawl");
                withdrawl = Convert.ToInt32(Console.ReadLine());
                int deposite=0;
                Console.WriteLine(" enter deposite");
                deposite = Convert.ToInt32(Console.ReadLine());
                Bank(actno, amount, withdrawl, deposite);

        }
    }
}
