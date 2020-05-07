using System;

namespace Inheritance
{
    class Shape
    {
        public void SetWidth(int w)
        {
            width = w;
        }
        public void SetHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }
    class Rectangle : Shape
    {
        public int GetArea()
        {
            return (width * height);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();
            Rect.SetWidth(5);
            Rect.SetHeight(7);
            Console.WriteLine("Total area: {0}", Rect.GetArea());
        }
    }
}
