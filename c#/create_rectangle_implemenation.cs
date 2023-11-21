using System;
namespace program
{
    class rectangle
    {
        int width;
        int height;
        float area;
        public void getdata(int width,int height)
        {
            this.width = width;
            this.height = height;
            area = width * height;
        }
        public void displaydata()
        {
            Console.WriteLine("area of rectangle:" + area);
        }
    }
    class program
    {
        static void Main(string [] args)
        {
            rectangle r = new rectangle();
            r.getdata(5, 10);
            r.displaydata();
            Console.ReadKey();

        }
    }
}
