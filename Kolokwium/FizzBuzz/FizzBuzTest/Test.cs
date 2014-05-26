using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;
using Xunit;

namespace FizzBuzTest
{
    public class Test
    {

        [Fact]
        public void FizzTest()
        {
            var fb = new FizzBuzzGame();

            Assert.Equal("Fizz", fb.Game(3));
        }

        [Fact]
        public void BuzzTest()
        {
            var fb = new FizzBuzzGame();

            Assert.Equal("Buzz", fb.Game(5));
        }

        [Fact]
        public void FizzBuzzTest()
        {
            var fb = new FizzBuzzGame();

            Assert.Equal("FizzBuzz", fb.Game(15));
        }

        [Fact]
        public void NumerTest()
        {
            var fb = new FizzBuzzGame();

            Assert.Equal("2", fb.Game(2));
        }
    }
}
