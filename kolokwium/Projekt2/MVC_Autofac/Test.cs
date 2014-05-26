using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lib;
using Xunit;

namespace MVC_Autofac
{
    public class Test : MvcApplication
    {
        protected ISomeStuff Input;
        protected Catcher catcher;

        [Fact]
        public void TestCatcher()
        {
            catcher = new Catcher();
            var generator = new Castle.DynamicProxy.ProxyGenerator();
            Input = generator.CreateClassProxy<SomeLongRunningStuff>(catcher);
            var startTime = DateTime.Now;
            Input.MakeSomeWork();
            var endTime = DateTime.Now;

            Assert.True((endTime-startTime).TotalSeconds >= 10);
        }
    }
}