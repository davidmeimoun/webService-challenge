using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(WebService));

        [WebMethod]
        public async Task<string> Fibonacci(int n, bool async)
        {
            if (async)
            {
                log.Debug("call FibonacciAsync method with argument " + n);
                int result = await FibonacciController.FibonacciAsync(n);
                return "Fibonacci(" + n + ") must return " + result;
            }
            else
            {
                log.Debug("call Fibonacci method with argument " + n);
                int result = FibonacciController.Fibonacci(n);
                return "Fibonacci(" + n + ") must return " + result;
            }
        }

        [WebMethod]
        public string XmlToJson(string xml)
        {
            log.Debug("call XmlToJson method with argument " + xml);
               return XmlToJsonController.XmlToJson(xml);
        }
    }
}
