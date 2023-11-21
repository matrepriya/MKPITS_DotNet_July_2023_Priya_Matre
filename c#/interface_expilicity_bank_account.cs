using System;
namespace program
{
    interface bank
    {
        string deposite(int actno, int amt);
    }
    class saving : bank
    {
        int actno;
        int bal = 1000;
        public string deposite(int actno, int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "deposite sucessfully,successfully, bal is " + bal;
        }
    }
    class program
    {
    static void Main(string[]args)
        {
            bank b;
            b = new saving();
            string str = b.deposite(1, 200);
            Console.WriteLine(str);
        }
    }
}
