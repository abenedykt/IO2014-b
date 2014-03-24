using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzz
{
    public class Testy
    {
        [Fact]
        public void returnFizzFor3()
        {
            var game = new Game();
            var r = game.Say(3);
            Assert.Equal("Fizz", r);
        }

        [Fact]
        public void returnBuzzFor5()
        {
            var game = new Game();
            var r = game.Say(5);
            Assert.Equal("Buzz", r);
        }

        [Fact]
        public void returnFizzBuzzFor15()
        {
            var game = new Game();
            var r = game.Say(15);
            Assert.Equal("FizzBuzz", r);
        }

        //[Fact]
        //public void returnFizzIfDivBy3()
        //{
        //    var game = new Game();
        //    var r = game.Say(21);
        //    Assert.Equal("Fizz", r);
        //}

        //[Fact]
        //public void returnBuzzIfDivBy5()
        //{
        //    var game = new Game();
        //    var r = game.Say(10);
        //    Assert.Equal("Buzz", r);
        //}
    }
}
