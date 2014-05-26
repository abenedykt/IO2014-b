using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib;
using Xunit;

namespace MVC_test
{
    public class Test
    {
        private SomeLongRunningStuff _stuff;

        public Test()
        {
            _stuff = new SomeLongRunningStuff();
        }
        [Fact]
        public void TestCatcher()
        {
            string message = string.Empty;
            var startTime = DateTime.Now;
            try
            {
                _stuff.MakeSomeWork();
            }
            catch (Exception exception)
            {
                message = exception.Message;
            }
            var endTime = DateTime.Now;

            Assert.Equal("catch me if you can", message);
        }

        [Fact]
        public void TestTime()
        {
            var startTime = DateTime.Now;
            try
            {
                _stuff.MakeSomeWork();
            }
            catch (Exception)
            {
                
            }
            var endTime = DateTime.Now;

            Assert.True((endTime-startTime).TotalSeconds >= 10);
        }
    }
}
