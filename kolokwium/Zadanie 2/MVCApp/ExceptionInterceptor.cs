using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac.Extras.DynamicProxy2;
using Castle.DynamicProxy;
using System.Diagnostics;

namespace MVCApp
{
    public class ExceptionInterceptor : IInterceptor
    {

        public void Intercept(IInvocation invocation)
        {
            try
            {
                invocation.Proceed();
            }
            catch(Exception e)
            {
                Trace.WriteLine(e.Message);
            }

        }

    }
}