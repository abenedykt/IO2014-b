using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;
using Xunit;

namespace Tests
{
    public class Test
    {
        [Fact]
        public void For3SayFizz()
        {
            var game = new Game();
            var r = game.Say(3);
            Assert.Equal("Fizz", r);
        }

        [Fact]
        public void For5SayBuzz()
        {
            var game = new Game();
            var r = game.Say(5);
            Assert.Equal("Buzz", r);
        }

        [Fact]
        public void For15SayFizzBuzz()
        {
            var game = new Game();
            var r = game.Say(15);
            Assert.Equal("FizzBuzz", r);
        }

        [Fact]
        public void ForMaxIntSayMaxInt()
        {
            var game = new Game();
            var r = game.Say(int.MaxValue);
            Assert.Equal("MaxInt", r);
        }

        [Fact]
        public void ForMinIntSayMinInt()
        {
            var game = new Game();
            var r = game.Say(int.MinValue);
            Assert.Equal("MinInt", r);
        }

        [Fact]
        public void For0SayLowerThenOne() // liczymy od 1 w gore
        {
            var game = new Game();
            var r = game.Say(0);
            Assert.Equal("Lower then one", r);
        }

        [Fact]
        public void For9IntSayFizz()
        {
            var game = new Game();
            var r = game.Say(9);
            Assert.Equal("Fizz", r);
        }

        [Fact]
        public void For55IntSayBuzz()
        {
            var game = new Game();
            var r = game.Say(55);
            Assert.Equal("Buzz", r);
        }

        [Fact]
        public void For45SayFizzBuzz()
        {
            var game = new Game();
            var r = game.Say(45);
            Assert.Equal("FizzBuzz", r);
        }

        [Fact]
        public void ForMinus5SayLowerThenOne() // liczymy od 1 w gore
        {
            var game = new Game();
            var r = game.Say(-5);
            Assert.Equal("Lower then one", r);
        }
    }
}
