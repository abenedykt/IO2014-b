using System;
using System.Collections.Generic;
using System.Diagnostics;
using Castle.DynamicProxy;

namespace ProjektPierwszy
{
    public class Interceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Trace.WriteLine("Calling method: " + invocation.Method.Name);
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
