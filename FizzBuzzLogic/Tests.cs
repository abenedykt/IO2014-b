using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzzLogic
{
    public class Tests
    {
        [Fact]
        public void SayFizzWhen3()
        {
            var game = new Game();
            var result = game.say(3);
            Assert.Equal("Fizz", result);
        }
        [Fact]
        public void SayBuzzWhen5()
        {
            var game = new Game();
            var result = game.say(5);
            Assert.Equal("Buzz", result);
        }
        [Fact]
        public void SayFizzBuzzWhen15()
        {
            var game = new Game();
            var result = game.say(15);
            Assert.Equal("FizzBuzz", result);
        }
    }
}
