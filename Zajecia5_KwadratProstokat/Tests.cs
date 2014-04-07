using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Zajecia5_KwadratProstokat
{
    public class Tests
    {
  
        [Fact]
        public void LiczObwodProstokatu()
        {
            var prost = new Prostokat(2,3);
            Assert.Equal(prost.liczObwod(), 10);
        }

        [Fact]
        public void LiczObwodKwadratu()
        {
            var kwadrat = new Kwadrat(2);
            Assert.Equal(kwadrat.liczObwod(), 8);
        }

        [Fact]
        public void LiczPoleProstokatu()
        {
            var prost = new Prostokat(2, 3);
            Assert.Equal(prost.liczPole(), 6);
        }

        [Fact]
        public void LiczPoleKwadratu()
        {
            var kwadrat = new Kwadrat(2);
            Assert.Equal(kwadrat.liczPole(), 4);
        }        

    }
}
