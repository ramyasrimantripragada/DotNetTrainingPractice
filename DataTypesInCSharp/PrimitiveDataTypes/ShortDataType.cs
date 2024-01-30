using System;

namespace PrimitiveDataTypes
{
    internal class ShortDataType
    {
        public static void printShortInfo()
        {
            //short
            short s = -18910;
            Console.WriteLine("Short...");
            Console.WriteLine("s = " + s);
            Console.WriteLine("Type of Variable s = " + s.GetType());
            Console.WriteLine("Size of Short = " + sizeof(short));
            Console.WriteLine("Minimum value of Short = " + short.MinValue);
            Console.WriteLine("Maximum value of Short = " + short.MaxValue);
            Console.WriteLine();
            //ushort
            ushort us = 18910;
            Console.WriteLine("Unsigned Short...");
            Console.WriteLine("us = " + us);
            Console.WriteLine("Type of Variable us = " + us.GetType());
            Console.WriteLine("Size of Unsigned Short = " + sizeof(ushort));
            Console.WriteLine("Minimum value of Unsigned Short = " + ushort.MinValue);
            Console.WriteLine("Maximum value of Unsigned Short = " + ushort.MaxValue);
            Console.WriteLine();
        }
    }
}
