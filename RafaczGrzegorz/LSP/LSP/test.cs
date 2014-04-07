using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LSP
{
   public class test
    {
        [Fact]
        public void Czymjek()
        {
           
            var p = new Kwadrat() {a = 6, b = 7};
            Assert.Equal(p.obwk(),24);

        }
        [Fact]
        public void Czymjep()
        {

            var p = new Prostokat() { a = 6, b = 6 };
            Assert.Equal(p.obwp(),24);

        }
    }
}
