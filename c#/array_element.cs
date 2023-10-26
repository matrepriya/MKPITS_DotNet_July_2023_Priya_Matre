using System;
namespace ConsoleApp8
{

    class Program
    {


        static void Main(string[] args)
        {
            //2 d array of 2 rows and 2 cols
            int[,] num = { { 1, 2 }, { 3, 4 } };
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(num[row, col] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}


