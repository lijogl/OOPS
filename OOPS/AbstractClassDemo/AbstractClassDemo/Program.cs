using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(100);
            Console.WriteLine(" Area od circle : " + circle.Area(40,0));
            Console.WriteLine(circle.SampleMethod());
            //Shape rectangle = new Rectangle();
            //Console.WriteLine(" Area of Rectagle : " + rectangle.Area(40,40));
            //Console.WriteLine(rectangle.SampleMethod());
            Shape rect = new Square();
            Console.WriteLine(" Area of square  : " + rect.Area(40, 60));
            Console.WriteLine(rect.SampleMethod());
            Console.ReadLine();
        }

        public abstract class Shape
        {
            public Shape()
            {

            }
            private int _height;
            public Shape(int height)
            {
                _height = height;
            }

            public string SampleMethod()
            {
                return "Hello sample method";
            }
            public abstract double Area(int height, int width);
        }

        internal class Circle : Shape
        {
            private int _height;
            public Circle(int height)
            {
                _height = height;
            }

            public override double Area(int height, int width)
            {
                return 2 * _height;
            }
        }

        internal class Rectangle : Shape
        {
            public override double Area(int height, int width)
            {
                return height + width;
            }
        }

        internal class Square : Shape
        {
            public override double Area(int hi, int wi)
            {
                return 4 * hi;
            }
        }

        //internal abstract class Rectangle : Shape
        //{
        //    //public override double Area(int height, int width)
        //    //{
        //    //    return height + width;
        //    //}
        //}

        //internal class Square : Rectangle
        //{
        //    public override double Area(int height, int width)
        //    {
        //        return 4 * height;
        //    }
        //}

    }
}
