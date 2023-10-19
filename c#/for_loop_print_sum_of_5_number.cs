using System;
namespace program
{
    class program
    {
        public static void Main(string[]args)
        {
            int num;
            int sum = 0;
            for(int counter=1;counter< 5;  counter++)
            {
                Console.WriteLine("enter and number");
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum+num;
            }
            Console.WriteLine(" sum of 5 no =" +sum);

                Console.ReadKey();
        }
    }

}
