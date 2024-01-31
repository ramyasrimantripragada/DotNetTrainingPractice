using System;

namespace PartialMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Creating PartialIncrement class object with num");
            PartialIncrement p = new PartialIncrement(num);
            Console.WriteLine("Displaying value of num");
            p.displayNumPublic();
            Console.WriteLine("Incrementing value of num");
            p.incrementNumPublic();
            Console.WriteLine("Displaying value of num");
            p.displayNumPublic();
            Console.ReadLine();
        }
    }
}
