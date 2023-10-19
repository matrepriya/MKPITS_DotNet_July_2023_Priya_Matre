using System;
namespace program
{
    class program
    {
        public static void Main(string[] args)
        {
            int number;
            int counter = 1;
            Console.WriteLine("enter no.");
            number = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            while (number > 0)
            {
                if (sum < number)
                {
                    if (counter %2!=0)
                    {
                        Console .WriteLine(odd no:{ 0}",cntr);
                        sum = sum + 1;
                    }
                }
                else
                {
                    break;
                }
                counter++;
            }
        }
    }
}
