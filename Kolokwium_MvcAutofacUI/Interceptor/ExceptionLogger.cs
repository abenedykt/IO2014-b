using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Kolokwium_MvcAutofacUI.Interceptor
{
    public class ExceptionLogger : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            try
            {
                invocation.Proceed();
            }
            catch (Exception exc)
            {
                Trace.WriteLine(exc.Message);
            }
        }
    }
}