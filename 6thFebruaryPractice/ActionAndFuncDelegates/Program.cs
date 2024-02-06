using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionAndFuncDelegates
{
    internal class Program
    {
        public static long getProduct(int num1,int num2)
        {
            return num1 * num2;
        }

        public static void printWelcomeMessage(string name)
        {
            Console.WriteLine("Welcome {0}!!", name);
        }
        static public void Main()
        {
            Console.WriteLine("Func Delegate Demo: returns a value");
            Func<int, int, long> result = getProduct;
            Console.WriteLine(result(2,3));
            Console.WriteLine("Type of result: "+result.GetType());
            Console.ReadLine();
            Console.WriteLine("Action Delegate Demo: performs action");
            Action<string> welcome = printWelcomeMessage;
            welcome("M.S.Dhoni");
            Console.WriteLine("Type of result: "+welcome.GetType());
            Console.ReadLine();
        }
    }
}
