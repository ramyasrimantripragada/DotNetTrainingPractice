using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefVsOutMethod
{
    internal class Program
    {
        //Ref as method parameter
        public void refIncrementDemo(ref int num)
        {
            ++num;
        }

        //Out as method parameter
        public void outAssigningDemo(out int num)
        {
            num = 96;
        }

        //ref as method return type
        public ref int findFirstOccuranceOf1(int[] arr)
        {
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    return ref arr[i];
                }
            }
            throw new Exception("Array doesnot contain 1");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int num;
            Console.WriteLine("Ref Vs. Out As Method Parameters");
            Console.WriteLine("num is not initialized");
            p.outAssigningDemo(out num);
            Console.WriteLine("Value of num after initializing using out: " + num);
            p.refIncrementDemo(ref num);
            Console.WriteLine("Value of num1 after Incrementing using ref: " + num);
            p.outAssigningDemo(out num);
            Console.WriteLine("Value of num after resetting value using out: " + num);
            Console.ReadLine();

            Console.WriteLine("Ref as Method return type");
            int[] a = { 7, 8, 938, 1, 96, 0 };
            Console.WriteLine("Array: " + string.Join(" ", a));
            Console.WriteLine("Finding first occurance of 1 in array");
            try
            {
                ref int reference = ref p.findFirstOccuranceOf1(a);
                Console.WriteLine("Chaging Value of 1 to 100");
                reference = 100;
                Console.WriteLine("Array after changing: " + string.Join(" ", a));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

            Console.WriteLine("Ref as keyword to declare reference variables");
            int val = 10;
            ref int refer = ref val;
            Console.WriteLine("Value of val(int val): " + val);
            Console.WriteLine("Value of refer(ref int refer): " + refer);
            refer = 9;
            Console.WriteLine("Changed value of refer to 9");
            Console.WriteLine("Value of val(int val): " + val);
            Console.WriteLine("Value of refer(ref int refer): " + refer);
            val = 8;
            Console.WriteLine("Changed value of val to 8");
            Console.WriteLine("Value of val(int val): " + val);
            Console.WriteLine("Value of refer(ref int refer): " + refer);
            Console.ReadLine();

            Console.WriteLine("Ref with Conditional Operator");
            int[] b = { 43, 87, 812, 82 };
            Console.WriteLine("Array a: " + string.Join(" ", a));
            Console.WriteLine("Array b: " + string.Join(" ", b));
            Console.WriteLine("Trying to change the vaue of 5th index to 999 in a or b based on their length");
            ref int found = ref ((5 < b.Length) ? ref b[5] : ref a[5]);
            found = 999;
            Console.WriteLine("Array a: " + string.Join(" ", a));
            Console.WriteLine("Array b: " + string.Join(" ", b));
            Console.WriteLine("Trying to change the vaue of 2nd index to 111 in a or b based on their length");
            ((2 < b.Length) ? ref b[2] : ref a[2]) = 111;
            Console.WriteLine("Array a: " + string.Join(" ", a));
            Console.WriteLine("Array b: " + string.Join(" ", b));
            Console.ReadLine();


        }
    }
}
