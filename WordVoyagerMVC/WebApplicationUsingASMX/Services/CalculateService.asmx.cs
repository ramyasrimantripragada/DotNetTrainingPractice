using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplicationUsingASMX.Services
{
    /// <summary>
    /// Summary description for CalculateService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculateService : System.Web.Services.WebService
    {
        [WebMethod]
        public int add(int num1, int num2)
        {
            return num1 + num2;
        }

        [WebMethod]
        public int subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        [WebMethod]
        public int multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        [WebMethod]
        public int divide(int num1, int num2)
        {
            return num1 / num2;
        }

        [WebMethod]
        public int modulus(int num1, int num2)
        {
            return num1 % num2;
        }
    }
}
