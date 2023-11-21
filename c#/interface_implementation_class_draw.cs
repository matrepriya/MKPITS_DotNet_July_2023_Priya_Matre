using System;
interface Drawable
{
    void draw();
}
    class Rectangle:Drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing rectangle");
        }
    }
     class circle:Drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing circle");
        }
    }
   class TestInterface
    {
       public static void Main()
        {
            Drawable d;
            d = new Rectangle();
            d.draw();
            d = new circle();
            d.draw();

        }
    }

