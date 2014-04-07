using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LSP
{
    public class Test
    {
        [Fact]
        public void Czy_obiekt_jest_kwadratem()
        {
            Kwadrat kwadrat = new Kwadrat();
            kwadrat.X = 4;
            kwadrat.Y = 4;

            Assert.Equal(kwadrat.X, kwadrat.Y);
        }

        [Fact]
        public void Czy_obiekt_jest_prostokatem()
        {
            Prostokat prostokat = new Prostokat();
            prostokat.X = 4;
            prostokat.Y = 6;

            Assert.NotEqual(prostokat.X, prostokat.Y);
        }

        [Fact]
        public void Pole_Prostoka()
        {
            Prostokat pro = new Prostokat();
            pro.X = 4;
            pro.Y = 6;
            Assert.Equal(pro.liczPole(), 24);
        }

        [Fact]
        public void Obwod_Prostokata()
        {201
            Prostokat pro = new Prostokat();
            pro.X = 4;
            pro.Y = 6;
            Assert.Equal(pro.liczObwod(), 20);
        }

        [Fact]
        public void Pole_Kwadrata()
        {
            Kwadrat pro = new Kwadrat();
            pro.X = 4;
            pro.Y = 4;
            Assert.Equal(pro.liczPole(), 16);
        }

        [Fact]
        public void Obwod_Kwadrata()
        {
            Kwadrat pro = new Kwadrat();
            pro.X = 4;
            pro.Y = 4;
            Assert.Equal(pro.liczObwod(), 16);
        }
    }
}
