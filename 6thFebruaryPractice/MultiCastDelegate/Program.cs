using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegate
{
    internal class Program
    {
        //multicast delegate return type should be void only
        //Rectangle
        private void computeRectangleArea(int length, int width)
        {
            Console.WriteLine("Area of Rectangle: " + (length * width));
        }

        private void computeRectanglePerimeter(int length, int width)
        {
            Console.WriteLine("Perimeter of Rectangle: " + (2 * (length + width)));
        }

        public delegate void RectangleDelegate(int length, int height);

        //Circle
        private void computeCircleArea(int radius)
        {
            Console.WriteLine("Area of Circle: " + (Math.PI * radius * radius));
        }

        private void computeCirclePerimeter(int radius)
        {
            Console.WriteLine("Perimeter of Circle: " + (Math.PI * 2 * radius));
        }

        public delegate void CircleDelegate(int radius);

        static void Main(string[] args)
        {
            Program p = new Program();
            RectangleDelegate rd = new RectangleDelegate(p.computeRectangleArea);
            rd += p.computeRectanglePerimeter;
            Console.Write("Enter length of Rectangle: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter width of Rectangle: ");
            int width = int.Parse(Console.ReadLine());
            rd(length, width);
            Console.ReadLine();
            CircleDelegate cd = new CircleDelegate(p.computeCircleArea);
            cd += p.computeCirclePerimeter;
            Console.Write("Enter radius of Circle: ");
            int radius = int.Parse(Console.ReadLine());
            cd(radius);
            Console.ReadLine();
        }
    }
}
