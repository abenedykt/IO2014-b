using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Castle.DynamicProxy;

namespace ProjektMVC
{
    public class InterceptorCatchEx : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Trace.WriteLine("Lets Catch Ex");

            try
            {
                invocation.Proceed();
            }

            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }
    }
}