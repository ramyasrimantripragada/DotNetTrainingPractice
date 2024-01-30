using System;

namespace PrimitiveDataTypes
{
    internal class IntDataType
    {
        public static void printIntInfo()
        {
            //int
            int i = -893818910;
            Console.WriteLine("Int...");
            Console.WriteLine("Value of Variable i = " + i);
            Console.WriteLine("Type of Variable i = " + i.GetType());
            Console.WriteLine("Size of Int = " + sizeof(int));
            Console.WriteLine("Minimum value of Int = " + int.MinValue);
            Console.WriteLine("Maximum value of Int = " +  int.MaxValue);
            Console.WriteLine();
            //uint
            uint ui = 893818910;
            Console.WriteLine("Unsigned Int...");
            Console.WriteLine("Value of Variable ui = " + ui);
            Console.WriteLine("Type of Variable ui = " + ui.GetType());
            Console.WriteLine("Size of Unsigned Int = " + sizeof(uint));
            Console.WriteLine("Minimum value of Unsigned Int = " + uint.MinValue);
            Console.WriteLine("Maximum value of Unsigned Int = " + uint.MaxValue);
            Console.WriteLine();
        }
    }
}
