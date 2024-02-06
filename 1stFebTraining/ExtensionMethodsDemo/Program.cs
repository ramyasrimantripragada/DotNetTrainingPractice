using System;
using System.Collections.Generic;

namespace ExtensionMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "100";
            Console.WriteLine("Value of String s: " + s);
            Console.WriteLine("Calling String Extension method");
            int i = s.ToInt(s);
            Console.WriteLine("Value of int i:" + i);
            LinkedList<int> list = new LinkedList<int>();
            Console.ReadLine();
        }
    }

    public static class StringExtension
    {
        public static int ToInt(this string str, string s)
        {
            return Convert.ToInt32(s);
        }
    }
}
