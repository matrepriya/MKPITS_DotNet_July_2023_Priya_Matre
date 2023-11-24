using System;
using System.Collections;
namespace CollectionsApplication
{
    class program
    {
        static void Main(string[]args)
        {
            Stack st = new Stack();
            st.Push('k');
            st.Push('M');
            st.Push('G');
            st.Push('W');
            
            foreach (char c in st)
            {
                Console.Write(c + "");
            }
            Console.WriteLine();
            st.Push('V');
            st.Push('H');
            Console.WriteLine("Add character");
            Console.WriteLine("current stack:");
            foreach (char c in st)
            {
                Console.WriteLine(c + "");
            }
            Console.WriteLine("Removing values");
            st.Pop();
            st.Pop();
            st.Pop();
            Console.WriteLine("current stack:");
            foreach (char c in st)
            {
                Console.WriteLine(c + "");
            }
            Console.ReadKey();
            
               
            
        }
    }
}
