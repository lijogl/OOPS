using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle();
            Console.WriteLine(" Area of circle : " + circle.Area(20, 0));

            IShape rect = new Rectangle();
            Console.WriteLine(" Area of rectangle : " + rect.Area(40,60));

            IShape cyl = new Cylinder();
            Console.WriteLine(" Area of Cylinder : " + cyl.Area(40, 60));

            IShape square = new Square();
            Console.WriteLine(" ARea of Square : " + square.Area(50,0));

            Console.ReadLine();
        }
    }

    interface IShape
    {
        //int height { get; set; }
        //int width { get; set; }
        double Area(int height, int width);
    }

    internal class Circle : IShape
    {
        //int _height { get; set; }
        //int _width { get; set; }
        //int IShape.height
        //{
        //    get
        //    {
        //        return _height;
        //    }

        //    set
        //    {
        //        _height = value;
        //    }
        //}

        //int IShape.width
        //{
        //    get { return _width; }
        //    set { _width = value; }
        //}

        //Circle(int height, int width)
        //{
        //    _height = height;
        //    _width = width;
        //}

        public double Area(int height, int width)
        {
            return 2*height;
        }
    }

    internal class Rectangle : IShape
    {
        public double Area(int height, int width)
        {
            return height + width;
        }

        //public virtual double Area(int height, int width)
        //{
        //    return height + width;
        //}
    }

    internal class Square : IShape
    {
        public double Area(int hi, int wi)
        {
            return 4 * hi;
        }
    }

    internal class Cylinder : Rectangle
    {
        public double Area(int a, int b)
        {
            return a * b;
        }
        //public new double Area(int a, int b)
        //{
        //    return a * b;
        //}
        //public override double Area(int a, int b)
        //{
        //    return a * b;
        //}
    }
}
