using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Math
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static int Fibonacci_Iterative(int n)
        {
            try
            {
                if (n < 1 || n > 100)
                {
                    log.Debug("Bad arguments");
                    return -1;
                }
                int firstnumber = 0, secondnumber = 1, result = 0;

                if (n == 0) return 0; //To return the first Fibonacci number   
                if (n == 1) return 1; //To return the second Fibonacci number   


                for (int i = 2; i <= n; i++)
                {
                    result = firstnumber + secondnumber;
                    firstnumber = secondnumber;
                    secondnumber = result;
                }

                return result;
            }
            catch (Exception e)
            {
                log.Error(e.StackTrace);
                return -1;
            }

        }
    }
}
