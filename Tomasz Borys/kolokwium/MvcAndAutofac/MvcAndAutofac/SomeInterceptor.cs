using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Extras.DynamicProxy2;
using Castle.DynamicProxy;
using System.Threading;
using System.Diagnostics;
using projekt2;

namespace MvcAndAutofac
{
    public class SomeInterceptor : IInterceptor
    {

        public void Intercept(IInvocation invocation)
        {
            Stopwatch wach = new Stopwatch();
            wach.Start();
            invocation.Proceed();
            wach.Stop();
            Trace.WriteLine(wach.ElapsedMilliseconds + "milisekund");
        }
    }
}