using System;
namespace program
{
    class program
    {
        static void Main(string[]args)
        {
            int[] arr = new int[3];
            for(int i=0; i<3;i++)
            {
                Console.WriteLine("enter element" + i + ":");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int Max = arr[0], Min = arr[0];
            for (int i=0;i<3; i++)
            {
                if (arr[i]>Max)
                {
                    Max = arr[i];
                }
                if (arr[i]>Min)
                {
                    Min = arr[i];
                }
            }
            Console.WriteLine("Maximum element is:" + Max);
            Console.WriteLine("Minimum element is:" + Min);
            Console.ReadKey();
            }
        }
    }

