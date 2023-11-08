using System;
namespace program
{
    class program
    {
        static void Main(string[]args)
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            int[] arr3 = new int[5];
            for(int i=0;i<5; i++)
            {
                Console.WriteLine(" enter element" + ":");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int j = 0;
            int k = 0;
            for(int i=0; i<5; i++)
            {
                if (arr1[i]%2==0)
                {
                    arr2[i] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }
            for(int i=0; i<j;j++)
            {
                Console.WriteLine("even num:" + arr2[i]);
            }
            for(int i=0; i<k;i++)
            {
                Console.WriteLine("odd num:+arr3[i]");
            }
            Console.ReadKey();
        }
    }
}
