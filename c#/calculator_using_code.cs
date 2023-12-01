using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public double Result { get; private set; }
        public void Add(double num)
        {
            Result = num;
        }
        public void substract(double num)
        {
            Result = num - Result;
        }
        public void Multiply(double num)
        {
            Result *= num;
        }
        public void Divide(double num)
        {
            if (num != 0)
            {
                Result /= num;
            }
            else
            {
                Console.WriteLine("Error:cannot divided by zero");
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
            Calculator mycalculator = new Calculator();
            mycalculator.Add(5);
            Console.WriteLine("Result:" + mycalculator.Result);
            mycalculator.substract(2);
            Console.WriteLine("Result:" + mycalculator.Result);
            mycalculator.Divide(2);
            Console.WriteLine("Result:" + mycalculator.Result);
            mycalculator.clear();
            Console.WriteLine("Result after clearing" + mycalculator.Result);
            Console.ReadKey();
        }
    }
            
        
          
        
        
        
     
        


       
            
          
            
    

       
            



            
        

        
}

