using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface ICalculateService
{

	[OperationContract]
	int Add(int num1, int num2);

	[OperationContract]
	int Subtract(int num1, int num2);

	[OperationContract]
	int Multiply(int num1, int num2);

	[OperationContract]
	int Divide(int num1, int num2);

	[OperationContract]
	int Modulus(int num1, int num2);
}

