using System;
namespace program
{
    interface bank
    {
        string deposite(int actno, int amt);
        string withdraw(int actno, int amt);
    }
    class account
    {
        public int actno;
        public int bal = 2000;
        public string showbalance()
        {
            return "bal is " + bal;
        }
    }
    class saving :account, bank
    {
        public string deposite(int actno,int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "deposite successfully succsessfully bal is" + bal;
        }
        public string withdraw(int actno,int amt)
        {
            this.actno = actno;
            bal = bal - amt;
            return "withdraw successfully, bal is + bal";
        }
    }
    class program
    {
        static void Main(string[] args)
        {


            saving b;
            b = new saving();
            string str = b.deposite(1, 300);
            Console.WriteLine(str);
            string res = b.withdraw(1, 200);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}

