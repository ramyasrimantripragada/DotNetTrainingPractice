using System;
using System.Runtime.InteropServices;
namespace ValueAndReferenceTypeDemo
{
    class Program
    {
        int i;
        Program(int i)
        {
            this.i = i;
        }
        public void setInt(int i)
        {
            this.i = i;
        }
        public int getInt()
        {
            return this.i;
        }
        public static void Main(string[] args)
        {
            unsafe
            {
                int num1 = 27;
                int* pointerToNumber = &num1;
                Console.WriteLine($"Value of the variable num1: {num1}");
                Console.WriteLine($"Address of the variable num1: {(long)pointerToNumber:X}");
                int num2 = num1;
                int* pointerToNum = &num2;
                Console.WriteLine($"Value of the variable num2: {num2}");
                Console.WriteLine($"Address of the variable num2: {(long)pointerToNum:X}");
                num2 = 5;
                Console.WriteLine("After changing num2 value");
                Console.WriteLine($"Value of the variable num1: {num1}");
                Console.WriteLine($"Value of the variable num2: {num2}");

                Program p = new Program(4);
                Program q = p;
                Program r = new Program(4);
                GCHandle handle = GCHandle.Alloc(p, GCHandleType.WeakTrackResurrection);

                long address = GCHandle.ToIntPtr(handle).ToInt64();
                GCHandle handle1 = GCHandle.Alloc(q, GCHandleType.WeakTrackResurrection);

                long address1 = GCHandle.ToIntPtr(handle1).ToInt64();
                Console.WriteLine("Address of p: " + address);
                Console.WriteLine("Address of q: " + address1);
                Console.WriteLine("Comparing p and q: " + Object.ReferenceEquals(p, q));
                Console.WriteLine("Comparing p and r: " + Object.ReferenceEquals(p, r));

                Console.WriteLine("Int i in Object P: " + p.getInt());
                Console.WriteLine("Int i in Object Q: " + q.getInt());

                Console.WriteLine("Changing value of i in Object Q to 9");
                q.setInt(9);
                Console.WriteLine("After changing value: ");
                Console.WriteLine("Int i in Object P: " + p.getInt());
                Console.WriteLine("Int i in Object Q: " + q.getInt());

            }

            Console.ReadLine();
        }
    }
}