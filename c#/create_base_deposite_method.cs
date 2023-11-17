using System;
namespace program
{
    class Account
    {
        public int actno;
        public int balance = 1000;
        public virtual string deposite(int actno, int amount)
        {
            return "deposite method of account class";
        }
        public string showbalance()
        {
            return "balance amounnt:" + balance;
        }
        class current :Account
        {
            public override string deposite(int actno, int amount)
            
                
                {
                    this.actno = actno;
                    balance = balance + amount;
                    return "amount deposite succeessfully in current class";
                }
            
            public class TestBase
            {
                public static void Main()
                {
                    Account act = new current();
                    string res = act.deposite(123, 2000);
                    Console.WriteLine("account no is " + act.actno);
                    Console.WriteLine(res);
                    res=act.showbalance();
                    Console.WriteLine(res);
                }
            }
        }
    }
}
