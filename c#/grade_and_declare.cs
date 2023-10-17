using System;
namespace gradeprogram
{
    class grade
    {
      public static void Main(string[]args)
        {
            char grade;
            string description;
            Console.WriteLine("enter a gradee");
            grade = Convert.ToChar(Console.ReadLine());
            switch (grade)
            {
                case 'E':
                    Console.WriteLine("Eccellent");
                    break;
                case 'v':
                    Console.WriteLine(" very good");
                    break;
                case 'g':
                    Console.WriteLine("Good");
                    break;

                case 'a':
                    Console.WriteLine("Average");
                    break;
                case 'f':
                    Console.WriteLine("fail");
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
            }
            Console.ReadKey();
        }
    }
}
