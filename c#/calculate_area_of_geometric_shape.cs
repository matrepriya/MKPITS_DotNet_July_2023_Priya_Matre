using System;
namespace geometricalprogram
{
    class program
    {
        public static void Main(string[]args)
        {
            int r, l, b,choice;
            float area;
            Console.WriteLine("enter your choice");
           choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("enter a radius");
                    r = Convert.ToInt32(Console.ReadLine());
                    area = 3.14f * r * r;
                    Console.WriteLine("area of circal=" + area);
                    break;
                case 2:
                    Console.WriteLine("enter a length ");
                    l = Convert.ToInt32(Console.ReadLine());
                   
                    Console.WriteLine("enter a breadth ");
                    b = Convert.ToInt32(Console.ReadLine());

                    area = l*b;
                    Console.WriteLine("area of circal=" + area);
                    
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;

            }
            Console.ReadKey();


            }


        }
}
