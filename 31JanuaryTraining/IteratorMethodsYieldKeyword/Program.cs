using System;
using System.Collections.Generic;

namespace IteratorMethodsYieldKeyword
{
    public class CSharpBuiltInTypes : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            Console.WriteLine("Inside GetEnumerator()");
            yield return "object";
            yield return "byte";
            yield return "uint";
            yield return "ulong";
            yield return "float";
            yield return "char";
            yield return "bool";
            yield return "ushort";
            yield return "decimal";
            yield return "int";
            yield return "sbyte";
            yield return "short";
            yield return "long";
            yield return "void";
            yield return "double";
            yield return "string";
            yield return "ref";
            yield return "out";
            yield return "in";
            yield return "params";
            Console.WriteLine("End of Iterator");
        }

       System.Collections.IEnumerator
       System.Collections.IEnumerable.GetEnumerator()
        {
            // Invoke IEnumerator<string> GetEnumerator() above.
            Console.WriteLine("Inside GetEnumerator invoking block");
            return GetEnumerator();
        }
    }
    public class Program
    {
        static void Main()
        {
            var keywords = new CSharpBuiltInTypes();
            Console.WriteLine("Value of keywords: " + string.Join(" ", keywords));
            foreach (string keyword in keywords)
            {
                Console.WriteLine(keyword);
            }
             Console.ReadLine();
        }
    }
}
