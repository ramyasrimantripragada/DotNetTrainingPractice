using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class CalculateService : ICalculateService
{

	public int Add(int num1, int num2)
	{
		return num1 + num2;
	}

	public int Subtract(int num1, int num2) { 
		return num1 - num2; 
	}

	public int Multiply(int num1, int num2)
	{
		return (num1 * num2);	
	}

	public int Divide(int num1, int num2)
	{
		return num1 / num2;
	}

	public int Modulus(int num1, int num2)
	{
		return num1 % num2;
	}
}
