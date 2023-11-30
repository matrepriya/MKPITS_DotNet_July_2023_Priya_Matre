using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringBuilder_class_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("priya"+"\n");
            sb.Append("vrushali");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("bye");
            Console.ReadKey();
        }
    }
}
