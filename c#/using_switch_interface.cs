using System;
namespace program
{
    interface bank
    {
        string deposite(int actno, int amount);
    }
    class saving : bank
    {
        int actno;
        int bal = 1000;
        int interest = 5000;
        public string deposite (int actno,int amount)
        {
            this.actno= actno;
            bal = bal + interest;
            return "actno:" + actno + "bal is :" + bal;
        }
    }
    class current : bank
    {
        int actno;
        int bal = 1000;
        public string deposite(int actno, int amount)
        {
            this.actno = actno;
            bal = bal + amount;
            return "actno:" + actno + "bal is :" + bal;
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            bank b = null;
            Console.WriteLine("enter saving or current");
            string acttype = Console.ReadLine();
            switch (acttype)
            {
                case "saving":

                    b = new saving();
                    break;
                case "current":
                    b = new current();
                    break;
            }
            string res = b.deposite(1, 700);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
