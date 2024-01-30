using System;

namespace PrimitiveDataTypes
{
    internal class DecimalDataType
    {
        public static void printDecimalInfo()
        {
            //decimal
            decimal dec = 56m;
            Console.WriteLine("Decimal....");
            Console.WriteLine("Dec = " + dec);
            Console.WriteLine("Type of variable  dec= " + dec.GetType());
            Console.WriteLine("Size of Decimal = " + sizeof(decimal));
            Console.WriteLine("Minimum value of Decimal = " + decimal.MinValue);
            Console.WriteLine("Maximum value of Decimal = " + decimal.MaxValue);
            Console.WriteLine();

        }
    }
}
