﻿using System;
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
            return "balance amount:" + balance;
        }
    }
    class current : Account
    {
        public override string deposite(int actno, int amount)
        {
            return base.deposite( int actno, int amount)
                {
                this.actno = actno;
                balance = balance + amount;
                return "amount deposited sucessfully without intererst in current class";
                }

        }
        class saving : Account
        {
            public override string deposite(int actno, int amount)
            {
                return base.deposite(int actno, intamount)
                    {
                    this.actno = actno;
                    int interest = 500;
                    balance = balance + amount + interest;
                    return "amount deposited successfully with interest in saving class";

                    }
            }
            public class TestBase
            {
                public static void Main()
                {

                    Console.WriteLine("enter account no ");
                    int actno = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter amount to be deposited ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter account type (saving or currrent)");
                    String acttype = Console.ReadLine();




                    Account act = null;
                    if (acttype == "saving")
                    {
                        act = new Saving();
                    }
                    else if (acttype == "current")
                    {
                        act = new Current();
                    }
                    String res = act.deposit(actno, amount);
                    Console.WriteLine("account no is " + act.actno);
                    Console.WriteLine(res);
                    res = act.showbalance();
                    Console.WriteLine(res);



                }

            }
        }
    }
}
