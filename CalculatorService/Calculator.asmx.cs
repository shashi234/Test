using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;


namespace CalculatorService
{
    /// <summary>
    /// Summary description for Calculator
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class Calculator : System.Web.Services.WebService
    {        

        [WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public int Add(int a, int b)
        {
            return a+b;
        }
        [WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public int Substract(int a, int b)
        {
            return a-b;
        }
        [WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public int Multiply(int a, int b)
        {
            return a*b;
        }
        [WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public float Division(int a, int b)
        {
            return (float)a/b;
        }
    }
}
