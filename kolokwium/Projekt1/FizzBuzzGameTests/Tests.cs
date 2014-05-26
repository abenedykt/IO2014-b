using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzGame;
using Xunit;

namespace FizzBuzzGameTests
{
    public class Tests
    {
        [Fact]
        public void Test0()
        {
            var game = new Game();
            var value = game.Say(0);
            Assert.Equal("0", value);
        }
        [Fact]
        public void Test1()
        {
            var game = new Game();
            var value = game.Say(1);
            Assert.Equal("1", value);
        }
        [Fact]
        public void Test3()
        {
            var game = new Game();
            var value = game.Say(3);
            Assert.Equal("Fizz", value);
        }
        [Fact]
        public void Test5()
        {
            var game = new Game();
            var value = game.Say(5);
            Assert.Equal("Buzz", value);
        }
        [Fact]
        public void Test10()
        {
            var game = new Game();
            var value = game.Say(10);
            Assert.Equal("Buzz", value);
        }
        [Fact]
        public void Test15()
        {
            var game = new Game();
            var value = game.Say(15);
            Assert.Equal("FizzBuzz", value);
        }
        [Fact]
        public void Test20()
        {
            var game = new Game();
            var value = game.Say(20);
            Assert.Equal("Buzz", value);
        }
        [Fact]
        public void Test30()
        {
            var game = new Game();
            var value = game.Say(30);
            Assert.Equal("FizzBuzz", value);
        }
        [Fact]
        public void TestMaxInt()
        {
            var game = new Game();
            var value = game.Say(int.MaxValue);
            Assert.Equal(int.MaxValue.ToString(), value);
        }
        [Fact]
        public void TestMinInt()
        {
            var game = new Game();
            var value = game.Say(int.MinValue);
            Assert.Equal(int.MinValue.ToString(), value);
        }
        [Fact]
        public void TestBelowZeroBuzz()
        {
            var game = new Game();
            var value = game.Say(-5);
            Assert.Equal("Buzz", value);
        }
        [Fact]
        public void TestBelowZeroFizz()
        {
            var game = new Game();
            var value = game.Say(-3);
            Assert.Equal("Fizz", value);
        }
        [Fact]
        public void TestBelowZeroFizzBuzz()
        {
            var game = new Game();
            var value = game.Say(-15);
            Assert.Equal("FizzBuzz", value);
        }
        [Fact]
        public void TestBelowZero2()
        {
            var game = new Game();
            var value = game.Say(-2);
            Assert.Equal("-2", value);
        }
    }
}
