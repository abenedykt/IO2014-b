using App;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Controllers;
using Xunit;

namespace WebApplication1.Tests
{
    public class TestClass
    {
        [Fact]
        public void IsThereAnInjection()
        {
            Assert.NotEqual(null, MvcApplicationInstance.Instance);
        }

        [Fact]
        public void IsThereAHomeController()
        {
            var tmp = MvcApplicationInstance.GetSubClasses<HomeController>();

            Assert.Equal(1, tmp.Count);
        }

        [Fact]
        public void HaveHomeCorrectController()
        {
            var tmp = MvcApplicationInstance.GetSubClasses<HomeController>().FirstOrDefault();

            Assert.Equal(typeof(SomeStuff), tmp.GetProperty("dane").GetType());
        }

        [Fact]
        public void IsHomeTake10Sec()
        {
            var tmp = MvcApplicationInstance.GetSubClasses<HomeController>().FirstOrDefault();

            Stopwatch st = new Stopwatch();
            st.Start();

            tmp.GetMethod("Index").Invoke(null, null);

            st.Stop();
            Assert.Equal(10, st.Elapsed.TotalSeconds);
        }
    }
}
