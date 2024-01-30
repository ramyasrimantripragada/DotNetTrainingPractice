using System;

namespace PrimitiveDataTypes
{
    internal class FloatDataType
    {
        public static void printFloatInfo()
        {
            //float
            float f = 12345.6789f;
            //printing value
            Console.WriteLine("Float...");
            Console.WriteLine("f: " + f);
            //printing type of variable
            Console.WriteLine("Type of Variable f: " + f.GetType());
            //printing size
            Console.WriteLine("Size of a Float variable: " + sizeof(float));
            //printing minimum & maximum value of float
            Console.WriteLine("Minimum value of Float: " + float.MinValue);
            Console.WriteLine("Maximum value of Float: " + float.MaxValue);
            Console.WriteLine();
        }
    }
}
