using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ObwodTest
{
    public class Test
    {
        [Fact]
        public void KwadratDwa()
        {
            var kwadrat = new Kwadrat();
            kwadrat.A = 2;
            var obw = kwadrat.Obwod();

            Assert.Equal(8, obw);
        }

        [Fact]
        public void ProstokatDwaTrzy()
        {
            var prostokat = new Prostokat();
            prostokat.A = 2;
            prostokat.B = 3;
            var obw = prostokat.Obwod();
            Assert.Equal(10, obw);
        }
    }

    
}
