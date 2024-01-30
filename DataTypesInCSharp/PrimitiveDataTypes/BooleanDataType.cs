using System;

namespace PrimitiveDataTypes
{
    internal class BooleanDataType
    {
        public static void printBooleanInfo()
        {
            //bool
            bool b = true; 
            Console.WriteLine("Boolean....");
            Console.WriteLine("Value of Variable b = " + b);
            Console.WriteLine("Type of Variable b = " + b.GetType());
            Console.WriteLine("Size of boolean = " + sizeof(bool));
            Console.WriteLine();
        }
    }
}
