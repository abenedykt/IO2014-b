using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspectsTest
{
    using System.Diagnostics;

    public class Interceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Debug.WriteLine("Calling method: " + invocation.Method.Name);

            invocation.Proceed();

            Debug.WriteLine("Done: result was {0}.", invocation.ReturnValue);
        }
    }
}