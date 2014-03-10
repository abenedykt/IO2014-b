using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace tbz1
{
    public class Class1
    {
        [Fact]
        void dlawartosci3zwracaFizz()
        {
            var game = new Game();
            var r = game.Say(3);
            Assert.Equal("Fizz", r);
        }

        [Fact]
        void dlawartosci5zwracaBuzz()
        {
            var game = new Game();
            var r = game.Say(5);
            Assert.Equal("Buzz", r);
        }

        [Fact]
        void dlawartosci15zwracaFizzBuzz()
        {
            var game = new Game();
            var r = game.Say(15);
            Assert.Equal("FizzBuzz", r);
        }

        [Fact]
        void dlawartosci6zwracaFizz()
        {
            var game = new Game();
            var r = game.Say(6);
            Assert.Equal("Fizz", r);
        }
        [Fact]
        void dlawartosci0zwraca0()
        {
            var game = new Game();
            var r = game.Say(0);
            Assert.Equal("0", r);
        }
    }
}
