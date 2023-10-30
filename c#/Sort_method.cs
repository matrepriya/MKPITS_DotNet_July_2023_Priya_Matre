using System;
namespace program
{
    class program
    {
        static void Main(string[]args)
        {
            int[] arr = { 1, 5, 3 };
            Array.Sort(arr);
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
