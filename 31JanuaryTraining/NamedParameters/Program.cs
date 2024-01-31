using System;

namespace NamedParameters
{
    internal class Program
    {
        static void printParamValues(String name1, String name2, String name3)
        {
            Console.WriteLine("Name1: " + name1);
            Console.WriteLine("Name2: " + name2);
            Console.WriteLine("Name3: " + name3);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Using required Params: name1: Ram, name2: Sita, name3: Lakshman");
            printParamValues("Ram", "Sita", "Lakshman");
            Console.WriteLine("Sending Ram as name1, Sita as name2, Lakshman as name3 in correct order");
            printParamValues(name1: "Ram", name2: "Sita", name3: "Lakshman");
            Console.WriteLine("Sending Ram as name1, Sita as name2, Lakshman as name3 in jumbled order");
            printParamValues(name2: "Sita", name3: "Lakshman", name1: "Ram");
            Console.WriteLine("Sending Ram as name1, Sita as name2 in first and second positions");
            printParamValues(name1: "Ram", name2: "Sita", "Lakshman");
            Console.WriteLine("Sending Sita as name2, Lakshman as name2 in second and thid positions");
            printParamValues("Ram", name2: "Sita", name3: "Lakshman");
            Console.WriteLine("Sending Ram as name1 (first argument)");
            printParamValues(name1: "Ram", "Sita", "Lakshman");
            Console.WriteLine("Sending Sita as name2 (second argument)");
            printParamValues("Ram", name2: "Sita", "Lakshman");
            Console.WriteLine("Sending Lakshman as name3 (third argument)");
            printParamValues("Ram", "Sita", name3: "Lakshman");
            Console.ReadLine();

        }
    }
}
