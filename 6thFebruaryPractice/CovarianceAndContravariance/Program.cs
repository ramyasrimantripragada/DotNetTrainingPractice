using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance
{


    public class Parent { }
    public class Child : Parent{ }

    public delegate Parent delMethod(Child c);
    internal class Program
    {
        public static Parent method1(Child c)
        {
            Console.WriteLine("Inside method 1");
            return new Parent();
        }

        public static Child method2(Child c)
        {
            Console.WriteLine("Inside method 2");
            return new Child();
        }

        public static Parent method3(Parent p)
        {
            Console.WriteLine("Inside method 3");
            return new Parent();
        }

        public static Child method4(Parent p)
        {
            Console.WriteLine("Inside method 4");
            return new Child();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Planet is inheriting from Moon");
            Console.WriteLine("Normal case scenario: param: Child required: Child sent , return: Parent expected: Parent received");
            delMethod d = method1;
            Parent p = d(new Child());
            Console.WriteLine("Type of p: " + p.GetType());
            d = method2;
            Console.WriteLine("Example of Covariance: param :Child required: Child sent, return:Parent expected: Child received");
            p = d(new Child());
            Console.WriteLine("Type of p: " + p.GetType());
            d = method3;
            Console.WriteLine("Example of Contravariance: param: Parent required: Child sent, return: Parent expected: Parent received");
            p = d(new Child());
            Console.WriteLine("Type of p: " + p.GetType());
            d = method4;
            Console.WriteLine("Example of Covariance and Contravariance: param: Parent required: Child sent, return: Parent expected, Child received");
            p = d(new Child());
            Console.WriteLine("Type of p: " + p.GetType());

            Console.ReadLine();
        }
    }
}
