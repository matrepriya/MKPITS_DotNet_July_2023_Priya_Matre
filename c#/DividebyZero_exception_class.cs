using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dividebyzero_exception_class
{
    class DivNumber
    {
        int result;
        DivNumber()
        {
            result = 0;
        }
        public void Division(int num1 , int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch(DivideByZeroException ee)
            {
                Console.WriteLine("exception : {0}", ee);
            }
            finally
            {
                Console.WriteLine("result : {0}", result);
            }
        }
        static void Main()
        {
            DivNumber d = new DivNumber();
            d.Division(25, 0);
            Console.ReadKey();
        }
    }
}
   