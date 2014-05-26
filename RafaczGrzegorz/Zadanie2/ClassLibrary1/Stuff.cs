using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace ClassLibrary1
{
    public class Stuff : IInterceptor,ISomeStuff
    {

            public void Intercept(IInvocation invocation)
            {
                var stop = new Stopwatch();
                stop.Start();

                invocation.Proceed();

                stop.Stop();
                Trace.WriteLine(stop.ElapsedMilliseconds );
            }



            public void MakeSomeWork()
            {
          
            }
    }
     
   

}
