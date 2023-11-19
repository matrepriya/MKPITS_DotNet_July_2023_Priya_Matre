using System;
namespace programmer
{
    class Employee
    {
        protected int salary;
    }
    class programmer : Employee
    {
        int bonus;
        public void getdata (int salary,int bunus)
        {
            this.salary = salary;
            this.bonus = bonus;
        }
        public void displaydata()
        {
            Console.WriteLine("salary" + salary);
            Console.WriteLine("bonus" + bonus);
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            programmer p = new programmer();
            p.getdata(23000, 5000);
            p.displaydata();
        }
    }
   
}
