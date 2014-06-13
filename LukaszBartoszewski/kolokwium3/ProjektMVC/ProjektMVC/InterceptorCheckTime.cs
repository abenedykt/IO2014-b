using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Castle.DynamicProxy;

namespace ProjektMVC
{
    public class InterceptorCheckTime : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Trace.WriteLine("Lets check time");

            var start = DateTime.Now;

            try
            {
                invocation.Proceed();
            }
            finally
            {
                var end = DateTime.Now;

                var time = end - start;

                Trace.WriteLine(time.Seconds + "secs & " + time.Milliseconds + "msecs");
            }
        }
    }
}