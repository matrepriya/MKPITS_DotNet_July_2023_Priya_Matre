using ConsoleApp6;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            for (int cnt = 1; cnt <= 5; cnt++)
            {
                Console.WriteLine("enter number ");
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine("sum of 5 no.  = " + sum);
            Console.ReadKey();
        }
    }
}


