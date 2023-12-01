using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcuulator_class_new_
{
    internal class calcuulator
    {
        public double Result { get; private set; }
        public void Add(double num)
        {
            Result += num;
        }
        private void substract(double num)
        {
            Result -= num;
        }
        public void Divide(double num)
        {
            if(num!=0)
            {
                Result /= num;
            }
            else
            {
                Console.WriteLine("Error:cannot divide by zero.");
            }
        }
          public void Exponentiate(double Expontiate)
          {
            Result = Math.POW (Result, Exponentiate);
          }
           public void square Root()
           {
                    if(Result>=0)
                    {
                       Result = Math.Sqrt(Result);
                    }
                else
                {
                Console.WriteLine("Error:cannot calculate square of a negative number.");
                }
           }
        public void clear()
        {
            Result = 0;
        }

    }
    class program
    {
        static void Main()
        {
            Calcuulate mycalculate = new Calcuulator();
            while(true)
            {
                Console.WriteLine("current Result:+mycalculator.Result");
                Console.WriteLine("1.Add");
                Console.WriteLine("2.substract");
                Console.WriteLine("3.Multiply");
                Console.WriteLine("4.Divide");
                Console.WriteLine("5.Exponentiate");
                Console.WriteLine("6.squareRoot");
                Console.WriteLine("7.clear");
                Console.WriteLine("0.Exit");
            }

        }
    }
        
        
    }
}
