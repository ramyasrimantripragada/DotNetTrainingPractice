using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarDynamicObjectDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 10.23;
            var c = 10.23f;
            var d = 10.23m;
            var f = "Hello";
            Console.WriteLine("value of a {0}, type {1}", a,
           a.GetType());
            Console.WriteLine("value of b {0}, type {1}", b,
           b.GetType());
            Console.WriteLine("value of c {0}, type {1}", c,
           c.GetType());
            Console.WriteLine("value of d {0}, type {1}", d,
           d.GetType());
            Console.WriteLine("value of f {0}, type {1}", f,
           f.GetType());
            var t = 12;
            Console.WriteLine("t1: " + t);
            //t = 11f; throws error as we cannot convert type of var variable after declaration
            //Console.WriteLine("t2= " + t);
            dynamic d1 = 10;
            dynamic d2;
            d2 = Console.ReadLine();
            dynamic d3 = "string value";
            Console.WriteLine("d1 " + d1);
            Console.WriteLine("d2 " + d2);
            Console.WriteLine("d2 " + d2.GetType());
            Console.WriteLine("d3 " + d3);
            Console.WriteLine("d3 " + d3.GetType());
            d3 = 12;
            Console.WriteLine("d3= " + d3);
            Console.WriteLine("d3 " + d3.GetType());
            //hit ENTER to exit*/
            Console.ReadLine();
            Console.WriteLine("Working with Object...");
            int num = 10;
            Object o1 = num;
            Object o2 = o1;
            Console.WriteLine("a= " + num);
            Console.WriteLine("o1= " + o1);
            Console.WriteLine("o2= " + o2);
            Console.WriteLine("o1 type " + o1.GetType());
            o1 = 10f;
            
            Console.WriteLine("a= " + num);
            Console.WriteLine("o1= " + o1);
            Console.WriteLine("o2= " + o2);
            Console.WriteLine("o1 type " + o1.GetType());
            Console.WriteLine("o2 type " + o2.GetType());
            Console.ReadLine();
        }
    }
}
