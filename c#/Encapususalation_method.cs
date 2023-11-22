using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp21
{
    class employee
    {
        // string empname;
        public string empname { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.empname = "priya"; //this will call setter 
            Console.WriteLine("empname " + emp.empname);
        }
    }
}  


