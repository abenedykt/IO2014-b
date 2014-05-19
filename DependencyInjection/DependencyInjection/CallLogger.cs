using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Web;
using Castle.DynamicProxy;

namespace DependencyInjection
{
    public class CallLogger : IInterceptor
    {
        private TextWriter _output;

        public CallLogger(TextWriter output)
        {
            _output = output;
        }

        public void Intercept(IInvocation invocation)
        {
            _output.Write("Calling method {0} with parameters {1}... ",
                invocation.Method.Name,
                string.Join(", ", invocation.Arguments.Select(n => (n ?? string.Empty).ToString()).ToArray()));

            invocation.Proceed();
            _output.WriteLine("Done: result was {0}.", invocation.ReturnValue);
        }
    }
}