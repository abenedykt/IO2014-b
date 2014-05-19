using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using Castle.DynamicProxy;

namespace WebApp
{
    public class Class2 : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Debug.WriteLine("Calling method {0} with parameters {1}... ",
             invocation.Method.Name,
             string.Join(", ", invocation.Arguments.Select(a => (a ?? "").ToString()).ToArray()));
            invocation.Proceed();
            Debug.WriteLine("Done: result was {0}.", invocation.ReturnValue); 
        }
    }
}