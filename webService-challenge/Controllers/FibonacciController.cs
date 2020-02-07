using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClassLibrary;

namespace webService_challenge.Controllers
{
    public class FibonacciController : ApiController
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static int Fibonacci(int n)
        {
            log.Debug("start Fibonacci with argument " + n);
            try
            {
                return ClassLibrary.Math.Fibonacci_Iterative(n);
            }

            catch (Exception e)
            {
                log.Error(e.StackTrace);
                return -1;
            }

        }

    }
}
