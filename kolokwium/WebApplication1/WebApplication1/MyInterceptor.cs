using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApplication1
{
    public class MyInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            try
            {
                invocation.Proceed();

            }
            catch(Exception e)
            {
                System.Diagnostics.Trace.WriteLine("Exception: " + e.Message);
            }
           
        }
    }
}
