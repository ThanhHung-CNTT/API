using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace mywebservice
{
    /// <summary>
    /// Summary description for Service
    /// </summary>
  
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    //https://localhost:44376/Service.asmx
    public class Service : System.Web.Services.WebService
    {
      //    <%@ WebService Language = "C#" CodeBehind="/App_Code/Service.cs"  Class="Service"%>

        [WebMethod]
       public int Multiplication(int a, int b)
        {
            return (a * b);
        }
    }
}
