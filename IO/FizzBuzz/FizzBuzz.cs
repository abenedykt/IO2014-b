using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace zajecia1
{
    public class FizzBuzz
    {
        [Fact]
        public void Test3()
        {
            var game = new Game();
            var r = game.Say(3);
            Assert.Equal("Fizz", r);
        }

        [Fact]
        public void Test5()
        {
            var game = new Game();
            var r = game.Say(5);
            Assert.Equal("Buzz", r);
        }

        [Fact]
        public void Test15()
        {
            var game = new Game();
            var r = game.Say(15);
            Assert.Equal("FizzBuzz", r);
        }

        [Fact]
        public void Test10()
        {
            var game = new Game();
            var r = game.Say(10);
            Assert.Equal("Buzz", r);
        }

        [Fact]
        public void Test2()
        {
            var game = new Game();
            var r = game.Say(2);
            Assert.Equal(null, r);
        }

        [Fact]
        public void Test30()
        {
            var game = new Game();
            var r = game.Say(30);
            Assert.Equal("FizzBuzz", r);
        }

        [Fact]
        public void Test0()
        {
            var game = new Game();
            var r = game.Say(0);
            Assert.Equal(null, r);
        }

        [Fact]
        public void TestMaxInt()
        {
            var game = new Game();
            var r = game.Say(int.MaxValue);
            Assert.Equal(null, r);
        }

        [Fact]
        public void TestMinInt()
        {
            var game = new Game();
            var r = game.Say(int.MinValue);
            Assert.Equal(null, r);
        }
    }
}
