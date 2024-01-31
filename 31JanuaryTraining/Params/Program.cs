using System;

namespace Params
{
    internal class Program
    {
        static int addNums(params int[] nums)
        {
            int total = 0;
            foreach (int i in nums)
            {
                total += i;
            }
            return total;
        }

        static long mulFirstWithSumOfRest(int num, params int[] nums) { 
            int total = 0;
            foreach(int i in nums)
            {
                total += i;
            }
            return num * total;
        }

        static long mulFirstWithSumOfParamsDivideBySecond(int num1, int num2,  params int[] nums) {
            int total = 0;
            foreach(int i in nums)
            {
                total += i;
            }
            return num1 * total / num2;
        }
        static void Main(string[] args)
        { 
            Console.WriteLine("Nums: 6, 27, 45, 28, 99, 203");
            Console.WriteLine("Calling addNums: " + addNums(6, 27, 45, 28, 99, 203));
            Console.WriteLine("Calling mulFirstWithSumOfRest: " + mulFirstWithSumOfRest(6, 27, 45, 28, 99, 203));
            Console.WriteLine("Calling mulFirstWithSumOfRestDivideBySecond: " + mulFirstWithSumOfParamsDivideBySecond(6, 27, 45, 28, 99, 203));
            Console.ReadLine();

        }
    }
}
