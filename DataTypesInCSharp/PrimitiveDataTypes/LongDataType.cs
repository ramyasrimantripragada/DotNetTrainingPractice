using System;

namespace PrimitiveDataTypes
{
    internal class LongDataType
    {
        public static void printLongInfo()
        {
            //long
            long l = -90909893818910;
            Console.WriteLine("Long...");
            Console.WriteLine("Value of Variable l = " + l);
            Console.WriteLine("Type of Variable l = " + l.GetType());
            Console.WriteLine("Size of Long = " + sizeof(long));
            Console.WriteLine("Minimum value of Long = " + long.MinValue);
            Console.WriteLine("Maximum value of Long = " + long.MaxValue);
            Console.WriteLine();
            //ulong
            ulong ul = 90909893818910;
            Console.WriteLine("Unsigned Long...");
            Console.WriteLine("Value of Variable ul = " + ul);
            Console.WriteLine("Type of Variable ul = " + ul.GetType());
            Console.WriteLine("Size of Unsigned Long = " + sizeof(ulong));
            Console.WriteLine("Minimum value of Unsigned Long = " + ulong.MinValue);
            Console.WriteLine("Maximum value of Unsigned Long = " + ulong.MaxValue);
            Console.WriteLine();
        }
    }
}
