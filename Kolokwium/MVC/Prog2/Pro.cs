using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace Prog2
{
    public class Pro : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Trace.WriteLine(invocation.Method.ReturnType.GenericParameterPosition.ToString()); 
        }
    }
}
