using System;

namespace PrimitiveDataTypes
{
    internal class CharDataType
    {
        public static void printCharInfo()
        {
            //char
            char c = 'P';
            Console.WriteLine("Char...");
            Console.WriteLine("Value of Variable c = " + c);
            Console.WriteLine("Type of Variable c = " + c.GetType());
            Console.WriteLine("Size of Char = " + sizeof(char));
            Console.WriteLine("Minimum value of Char = " + (int)(char.MinValue));
            Console.WriteLine("Maximum value of Char = " + (int)(char.MaxValue));
            Console.WriteLine();
        }
    }
}
