// C# program to illustrate the use of Delegates
using System;
namespace DelegateDemo
{
    class DelegateUsage
    {

        // Declaring the delegates
        // Here return type and parameter type should 
        // be same as the return type and parameter type
        // of the two methods
        // "addnum" and "subnum" are two delegate names
        public delegate void add3num(int a, int b, int c);
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);

        // method "sum"
        private void sum(int a, int b)
        {
            Console.WriteLine("({0} + {1}) = {2}", a, b, a + b);
        }

        private void sum(int a, int b, int c)
        {
            Console.WriteLine("({0} + {1} + {2}) = {3}", a, b, c, a + b + c);
        }

        // method "subtract"
        public void subtract(int a, int b)
        {
            Console.WriteLine("(100 - 60) = {0}", a - b);
        }

        // Main Method
        public static void Main(String[] args)
        {

            // creating object "obj" of class "DelegateTesting"
            DelegateUsage obj = new DelegateUsage();

            addnum del_obj1 = new addnum(obj.sum);
            add3num del_obj3 = new add3num(obj.sum);
            subnum del_obj2 = new subnum(obj.subtract);

            // pass the values to the methods by delegate object
            del_obj1(100, 40);
            del_obj3(100, 200, 300);
            del_obj2(100, 60);
            Console.ReadLine();

        }
    }
}
