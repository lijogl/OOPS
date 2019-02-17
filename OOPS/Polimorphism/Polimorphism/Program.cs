using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            float rectArea = area(30, 40);
            Console.WriteLine(" Area of Rectangle = " + rectArea);
            float circleArea = area(30);
            Console.WriteLine("Area of Circle = " + circleArea);
            float squareArea = area(float.Parse("20.0"));
            Console.WriteLine("Area of Square = " + squareArea);
            float triangleArea = area(30, 20, 50);
            Console.WriteLine("Area of Triangle = " + triangleArea);
            float nullableArea = area(100, null);
            Console.WriteLine("Area of Triangle = " + nullableArea);
            Console.ReadLine();
        }

        private static float area(float width, float height)
        {
            return width + height;
        }

        private static float area(int radius)
        {
            return 2 * radius;
        }

        private static float area(float width)
        {
            return 4 * width;
        }

        private static float area(float length, float breadth, float height)
        {
            return length + breadth + height;
        }

        private static float area(float width, float? height)
        {
            return width;
        }

        //private static int area(int width)
        //{
        //    return 4*width;
        //}
    }
}
