using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Kolokwium_MvcAutofacUI.Interceptor
{
    public class TimeLogger : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var startTime = DateTime.UtcNow;
            invocation.Proceed();
            var endTime = DateTime.UtcNow;
            Trace.WriteLine(string.Format("Wykonano w {0} sekund.", (endTime - startTime).TotalSeconds));

        }
    }
}