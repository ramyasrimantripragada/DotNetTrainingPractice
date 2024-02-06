using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Animal
    {
        private void walk()
        {
            Console.WriteLine("Animal is walking...");
        }

        private static void talk()
        {
            Console.WriteLine("Animal is talking in static method...");
        }

        //creating delegate for above method
      
        public delegate void walkDelegate();
        static void Main()
        {
            Console.WriteLine("Example for Method Encapsulation using Delegate");
            Animal animal = new Animal();
            walkDelegate wd = animal.walk;
            wd();
            Console.WriteLine("Combining above Delegate with Static method");
            wd = Animal.talk;
            wd();
            Console.ReadLine();
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //the condition which we are giving in anonymous delegate and lambda expressions are predicates
            Console.WriteLine("Array of Integers: ");
            foreach (int num in nums)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine("\nAnonymous Delegates Demo");
            Console.WriteLine("Returning num if num%3==0, or num%5==0");
            int[] ans = Array.FindAll(nums,
                delegate (int n)
                {
                    return n % 3 == 0 || n % 5 == 0;

                });
            Console.WriteLine("Result: ");
            foreach (int num in ans)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
            string[] strs = new string[] { "abc", "mom", "net", "madam", "noon", "truck", "racecar" };
            Console.WriteLine("" +
                "Array of string: ");
            foreach(string str in strs)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine("\nLambda expressions Delegates Demo");
            Console.WriteLine("Returning str if str is a palindrome");
            string[] res = Array.FindAll(strs, i => i.SequenceEqual(i.Reverse()));
            Console.WriteLine("Result: ");
            foreach(string str in res)
            {
                Console.Write(str + " ");
            }

            Console.ReadLine();
        }
    }
}
