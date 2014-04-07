using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Test
{
    public class Tests
    {
        [Fact]
        public void CheckObwKwadrat()
        {    
            var kw = new Kwadrat(1);

            kw.LiczObw();

            Assert.Equal(kw.obw, 4);
        }

        [Fact]
        public void CheckObwProstokat()
        {
            var kw = new Prostokat(1,2);

            kw.LiczObw();

            Assert.Equal(kw.obw, 6);
        }

        [Fact]
        public void CheckPoleProstokat()
        {
            var kw = new Prostokat(1,2);

            kw.LiczPole();

            Assert.Equal(kw.pole, 2);
        }

        [Fact]
        public void CheckPoleKwadrat()
        {
            var kw = new Kwadrat(4);

            kw.LiczPole();

            Assert.Equal(kw.pole, 16);
        }

        [Fact]
        public void Test()
        {
           var p = new Kwadrat(1);
           var p1 = new Prostokat(1, 2);

           p1.LiczObw();
           p.LiczObw();

           Assert.Equal(p.obw, 4);
           Assert.Equal(p1.obw, 6);
        }
    }
}
