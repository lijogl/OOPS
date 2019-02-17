using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace OverRiding
{
    class Program
    {
        static void Main(string[] args)
        {
            parentClass p = new childClass();
            string a = p.method();
            childClass c = new childClass();
            //int b = c.method(10);
            Console.WriteLine(a);
            //Console.WriteLine(b);

            parentClass p1 = new parentClass();
            string a1 = p1.method(10);
            Console.WriteLine(a1);
            parentClass c1 = new childClass();
            string b1 = c1.method(10);
            Console.WriteLine(b1);
            Console.ReadLine();
        }

        
    }

    internal class parentClass
    {
        public string method()
        {
            return "parnet class method called.";
        }

        public virtual string method(int a)
        {
            return "parnet class method called." + a;
        }
    }

    internal class childClass : parentClass
    {
        //public int method(int a)
        //{
        //    return a;
        //}

        public string method()
        {
            return "Child class called.";
        }

        //public override string method(int a)
        //{
        //    return "child class method called." + a;
        //}

        public override string method(int a)
        {
            return "child class method called." + a;
        }
    }
}
