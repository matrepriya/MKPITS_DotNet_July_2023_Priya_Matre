using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexout_of_rangeexception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            arr[0] = 22;
            arr[1] = 23;
            arr[2] = 24;
            try
            {
                for (int i = 0; i < 3; i++) 
                {
                    Console.WriteLine("arr=" + arr[1]);
                }
            }
            catch(InvalidCastException ee)
            {
                Console.WriteLine("catch block is executiing");
                Console.WriteLine(ee.ToString());
            }
            catch(Exception ee)
            {
                Console.WriteLine(ee.ToString());
            }
            finally
            {
                Console.WriteLine("finally block isexecuting");
            }
            Console.WriteLine("bye");
            Console.ReadKey();
        }
    }
}
