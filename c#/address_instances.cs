using System;
namespace program
{
    class person
    {
        string name;
        string address;
        int age;
        public void getdata(string name, string address, int age)
        {
            this.age = age;
            this.name = name;
            this.address = address;
            this.name = name;
        }
        public void displaydata()
        {
            Console.WriteLine("name:" + name);
            Console.WriteLine("address:" + address);
            Console.WriteLine("age:" + age);
        }
    }
    static void Main(string[] args)
    {
        person per = new person();
        Console.WriteLine("enter name:");
        string n = (Console.ReadLine());
        Console.WriteLine("enter address:");
        string age = (Console.ReadLine());
        Console.WriteLine("enter age");
        int a = Convert.ToInt32(Console.ReadLine());
        per.getdata(n, age, a);
        per.displaydata();
        Console.ReadKey();

    }
}




