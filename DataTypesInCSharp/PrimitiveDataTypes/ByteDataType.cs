using System;

namespace PrimitiveDataTypes
{
    internal class ByteDataType
    {
        public static void printByteInfo()
        {
            //sbyte
            sbyte sb = -10;
            Console.WriteLine("Signed Byte...");
            Console.WriteLine("Value of Variable sb = " + sb);
            Console.WriteLine("Type of Variable sb = " + sb.GetType());
            Console.WriteLine("Size of Signed Byte = " + sizeof(sbyte));
            Console.WriteLine("Minimum value of Signed Byte = " + sbyte.MinValue);
            Console.WriteLine("Maximum value of sbyte = " + sbyte.MaxValue);
            Console.WriteLine();
            //byte
            byte b = 10;
            Console.WriteLine("Byte...");
            Console.WriteLine("Value of Variable b = " + b);
            Console.WriteLine("Type of Variable b = " + b.GetType());
            Console.WriteLine("Size of Byte = " + sizeof(byte));
            Console.WriteLine("Minimum value of Byte = " + byte.MinValue);
            Console.WriteLine("Maximum value of Byte = " + byte.MaxValue);
            Console.WriteLine();
        }
    }
}
