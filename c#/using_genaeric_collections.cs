using System;
namespace program
{
    class Langs
    {
        static void Main(string[]args)
        {
            List<string> Langs = new List<string>();
            Langs.Add("Java");
            Langs.Add("c#");
            Langs.Add("c");
            Langs.Add("c#");
            Langs.Add("ruby");
            Langs.Add("Janascript");
            Console.WriteLine(Langs.Contains("c#"));
            Console.WriteLine(Langs[1]);
            Console.WriteLine(Langs[2]);
            Langs.Remove("c#");
            Langs.Remove("c");
            Console.WriteLine(Langs.Contains("c"));
            Langs.Insert(4, "Haskell");
            Langs.Sort();
            foreach (String La in Langs)
            {
                Console.WriteLine(La);
            }
            Console.ReadKey();
        }
    }
}
