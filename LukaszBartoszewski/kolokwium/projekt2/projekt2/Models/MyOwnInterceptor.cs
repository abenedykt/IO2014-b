using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Castle.DynamicProxy;

namespace projekt2.Models
{
    public class MyOwnInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var start = DateTime.Now;
            
            invocation.Proceed();

            var end = DateTime.Now;

            var time = end - start;
            Trace.WriteLine(time.Seconds + "secs & " + time.Milliseconds + "msecs");
        }
    }

}