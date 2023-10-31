using System;
namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            Empno emp = new Empno();
            emp.getdata(123, "priya", "manager", 60000);
            emp.display();
            Console.ReadKey();
        }
        class Empno
        {
            int employee_no;
            string emp_designation;
            int emp_salary;
            string emp_name;
            public void getdata(int no, string emname, string designation, int salary)
            {
                employee_no = no;
                emp_designation = designation;
                emp_salary = salary;
                emp_name = emname;
            }
            public void display()
            {
                Console.WriteLine("Employeeno" + employee_no);
                Console.WriteLine("Employee name" + emp_name);
                Console.WriteLine("Employee slary" + emp_salary);
                Console.WriteLine("Employee designation" + emp_designation);
            }
        }
    }
}