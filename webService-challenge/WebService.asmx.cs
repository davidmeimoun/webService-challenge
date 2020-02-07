using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using webService_challenge.Controllers;

namespace webService_challenge
{
    /// <summary>
    /// Description résumée de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebService1 : System.Web.Services.WebService
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [WebMethod]
        public string Fibonacci(int n)
        {
            log.Debug("call Fibonacci method with argument "+n);
                int result = FibonacciController.Fibonacci(n);
                return "Fibonacci(" + n + ") must return "+result;
        }

        [WebMethod]
        public string XmlToJson(string xml)
        {
            log.Debug("call XmlToJson method with argument " + xml);
               return XmlToJsonController.XmlToJson(xml);
        }
    }
}
