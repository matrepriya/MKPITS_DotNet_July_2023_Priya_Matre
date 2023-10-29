using System;
namespace program
{
    class program
    {
        static void Main(string[]args)
        {
            int i, j;
            int[,] arr1 = new int[2,2];
            Console.Write(" array element");
            for (i=0; i<2; i++)
            {
                for (j=0; j<2; j++)
                {
                    Console.Write("elemement [{0}-{1}]:", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.Write("\n");
            Console.Write("\n matrix is :\n");
                for(i=0; i<2;i++)
            {
                Console.Write("\n");                   
                for (j=0;j<2;j++)
                {
                    Console.Write("{0} \t ", arr1[i, j]);
                    Console.Write("\t");
                    Console.WriteLine(" Transpose of matrix ");
                    for (i=0; i<2;i++)
                    {
                        Console.WriteLine(arr1[i, j] + "\t");
                    }
                    Console.WriteLine("\n");
                }
                Console.ReadKey();
            }
        }
    }
}
