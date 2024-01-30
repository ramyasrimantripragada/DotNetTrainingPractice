using System;

namespace PrimitiveDataTypes
{
    internal class DoubleDataType
    {
        public static void printDoubleInfo()
        {
            double dou = 12345.6789;
            //printing value
            Console.WriteLine("Double...");
            Console.WriteLine("d: " + dou);
            //printing type of variable
            Console.WriteLine("Type of variable d: " + dou.GetType());
            //printing size
            Console.WriteLine("Size of a Double variable: " + sizeof(double));
            //printing minimum & maximum value of double
            Console.WriteLine("Minimum value of double: " + double.MinValue);
            Console.WriteLine("Maximum value of double: " + double.MaxValue);
        }
    }
}
