using System;
using System.Collections;
using System.ComponentModel.Design;

namespace collectionsApplication
{
    class programe
    {
        static void Main(string[] arhs)
        

        {
            Hashtable ht = new Hashtable();
            ht.Add("001", "Zara Ali");
            ht.Add("002", "Abida Rehman");
            ht.Add("003", "Joe Holzer");
            ht.Add("004", "Mausam Benazir Nur");
            ht.Add("005", "M.Amlan");
            ht.Add("006", "M.Arif");
            ht.Add("007", "Ritesh Saika");
            if (ht.ContainsValue("NuhaAli")) 
            {
                Console.WriteLine("This student name is already in the list");
            }

            

            else
                {
                    ht.Add("008", "NuhaAli");
                }
                ICollection Key = ht.Keys;
                foreach (string k in Key)
                {
                    Console.WriteLine(k + ":" + ht[k]);
                }
                Console.ReadKey();




            
        }
    }
}
    
                  
