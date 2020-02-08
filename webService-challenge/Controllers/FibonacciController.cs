using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ClassLibrary;

namespace webService_challenge.Controllers
{
    public class FibonacciController : ApiController
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(FibonacciController));
        public static int Fibonacci(int n)
        {
            log.Debug("start Fibonacci with argument " + n);
            try
            {
                return ClassLibrary.Math.Fibonacci_Iterative(n);
            }

            catch (Exception e)
            {
                log.Error("Error in Fibonacci : an error occurred." + e.ToString());
                return -1;
            }

        }

        public static Task<int> FibonacciAsync(int n)
        {
            log.Debug("start Fibonacci with argument " + n);
            return ClassLibrary.Math.Fibonacci_IterativeAsync(n);
        }

    }
}
