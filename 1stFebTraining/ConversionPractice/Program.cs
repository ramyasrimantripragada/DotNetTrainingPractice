using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConversionPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 2147483647;
            long l = 2147483648;
            Console.WriteLine("Value type to Value Type: Type conversion (c++ type casting techniques");
            Console.WriteLine("Value of int i: " + i);
            Console.WriteLine("Value of long l: " + l);
            Console.WriteLine("Converting int to long using implicit conversion..");
            long li = i;
            Console.WriteLine("Value of long li: " + li);
            Console.WriteLine("Converting long to int using explicit conversion..");
            int il = (int)l;
            Console.WriteLine("Value of int il: " + il);
            Console.WriteLine();
            Console.WriteLine("Conversion using Convert(base data type to another base type");
            bool b = Convert.ToBoolean(0);
            Console.WriteLine("Converting string true to bool b: " + b);
            Object sobj = Convert.ChangeType(b, typeof(string));
            String s = Convert.ToString(sobj);
            Console.WriteLine(s +" "+ sobj.GetType());
            Console.WriteLine("Using Parse(strings to number type): ");
            String num = "198392";
            Console.WriteLine("String num: " + num);
            Console.WriteLine("Converting to Int using Prase: " + int.Parse(num));
            Console.WriteLine("Converting to Float using Parse: " + float.Parse(num));
            Console.WriteLine("Converting to Decimal using Parse: " + decimal.Parse(num));
            Console.WriteLine("Converting to Long using Parse: " + long.Parse(num));
            Console.WriteLine();
            Console.WriteLine("Using TryParse: will parse if possible and returns true and uses out to set value");
            num = "abcd";
            Console.WriteLine("String num = " + num);
            bool status = int.TryParse(num, out i);
            Console.WriteLine("Status of Conversion: " + status);
            Console.WriteLine("Value of int: " + i);
            num = "12";
            Console.WriteLine("String num = " + num);
            status = int.TryParse(num, out i);
            Console.WriteLine("Status of Conversion: " + status);
            Console.WriteLine("Value of int: " + i);
            Console.WriteLine();
            Console.WriteLine("Using Boxing and Unboxing: using objects ");
            Console.WriteLine("Value of Int i: " + i);
            Console.WriteLine("Converting to Object o(Boxing)");
            Object o = i;
            Console.WriteLine("Value of object o: " + o);
            Console.WriteLine("Type of object o: "+o.GetType());
            Console.WriteLine("Converting Object o to Int i(unboxing)");
            i = (int)o;
            Console.WriteLine("Value of Int i: " + i);
            Console.WriteLine("Type of Int i: " + i.GetType());
            Console.WriteLine("Value of object o: " + o);
            Console.WriteLine("Type of object o: " + o.GetType());
            o = 123l;
            Console.WriteLine("Assigning long value to object o");
            Console.WriteLine("Type of o: " + o.GetType());
            Console.ReadLine();
        }
    }
}
