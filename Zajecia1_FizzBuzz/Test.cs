using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Zajecia1_FizzBuzz
{
    public class Test
    {
        [Fact]
        public void Dla_Wartosci_3_Zwroc_Fizz()
        {
            var game = new Game();
            var r = game.Say(3);
            Assert.Equal("Fizz", r);
        }

        [Fact]
        public void Dla_Wartosci_5_Zwroc_Bazz()
        {
            var game = new Game();
            var r = game.Say(5);
            Assert.Equal("Bazz", r);
        }

        [Fact]
        public void Dla_Wartosci_15_Zwroc_FizzBazz()
        {
            var game = new Game();
            var r = game.Say(15);
            Assert.Equal("FizzBazz", r);
        }

        [Fact]
        public void Dla_Wartosci_MaxInt_Zwroc_MaxInt()
        {
            var game = new Game();
            var r = game.Say(int.MaxValue);
            Assert.Equal("MaxInt", r);
        }

        [Fact]
        public void Dla_Wartosci_MinInt_Zwroc_MaxInt()
        {
            var game = new Game();
            var r = game.Say(int.MinValue);
            Assert.Equal("MinInt", r);
        }
    }
}
