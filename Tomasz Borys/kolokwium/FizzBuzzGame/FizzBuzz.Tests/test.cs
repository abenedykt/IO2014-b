using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FizzBuzzGra;

namespace FizzBuzz.Tests
{
    public class test
    {
        [Fact]
        public void FizzBuzztest()
        {
            Game fb = new Game();
            Assert.Equal("FizzBuzz", fb.play(15));
        }
        [Fact]
        public void Buzztest()
        {
            Game fb = new Game();
            Assert.Equal("Buzz", fb.play(5));
        }
        [Fact]
        public void Fizztest()
        {
            Game fb = new Game();
            Assert.Equal("Fizz", fb.play(3));
        }
        [Fact]
        public void liczbatest()
        {
            Game fb = new Game();
            Assert.Equal("7", fb.play(7));
        }
    }
}
