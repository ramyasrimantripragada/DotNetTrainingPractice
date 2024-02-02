using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArithmeticOperations
{
    /// <summary>
    /// Class for Performing Basic Arithmetic Operations on Two Integers
    /// </summary>
    public class ArithmeticOperationsClass
    {
       
        /// <summary>
        /// Method to perform addition on Two Integers 
        /// </summary>
        /// <param name="num1">First Integer</param>
        /// <param name="num2">Second Integer</param>
        /// <returns>Integral sum of num1 and num2</returns>
        public int add(int num1, int num2)
        {
            return num1 + num2;
        }
        
        /// <summary>
        /// Method to perform subtraction on Two Integers
        /// </summary>
        /// <param name="num1">First Integer</param>
        /// <param name="num2">Second Integer</param>
        /// <returns>Integral subtraction of num2 from num1</returns>
        public int subtract(int num1, int num2)
        {
            return num1 - num2;
        }
       
        /// <summary>
        /// Method to perform multiplication on Two Integers
        /// </summary>
        /// <param name="num1">First Integer</param>
        /// <param name="num2">Second Integer</param>
        /// <returns>Integral product of num1 and num2</returns>
        public int multiply(int num1, int num2)
        {
            return num1 * num2;
        }
       
        /// <summary>
        /// Method to perform division on Two Integers 
        /// </summary>
        /// <param name="num1">First Integer</param>
        /// <param name="num2">Second Integer</param>
        /// <returns>Integral division quotient of num1 divided by num2</returns>
        public int divide(int num1, int num2)
        {
            return num1 / num2;
        }

        /// <summary>
        /// Method to perform modular division on Two Integers 
        /// </summary>
        /// <param name="num1">First Integer</param>
        /// <param name="num2">Second Integer
        /// </param>
        /// <returns>Integral division remainder of num1 divided by num2</returns>
        public int modular(int num1, int num2)
        {
            return num1 % num2;
        }

    }
}
