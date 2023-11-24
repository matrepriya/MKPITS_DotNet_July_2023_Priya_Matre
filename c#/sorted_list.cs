using System;
using System.Collections;
namespace collectionsApplication
{
    class program
    {
        static void Main(string[] args)
        {
            SortedList SI = new SortedList();
            SI.Add("001", "Zara Ali");
            SI.Add("002", "Zara Ali");
            SI.Add("003", "Zara Ali");
            SI.Add("004", "Zara Ali");
            SI.Add("005", "Zara Ali");
            SI.Add("006", "Zara Ali");
            SI.Add("007", "Zara Ali");
            if (SI.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                SI.Add("008", "Nuha Ali");
            }
            ICollection key = SI.Keys;
            foreach (string k in key)
            {
                Console.WriteLine(k + ":" + SI[k]);
            }
        }
    }
}
    
    
    
        
        

   
    

