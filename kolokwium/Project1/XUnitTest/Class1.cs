using Project1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTest
{
    public class TestClass
    {
        [Fact]
        public void Numeric0Test()
        {
            FizzBuzzGame a = new FizzBuzzGame();

            Assert.Equal("0", a.GetValue(0));
        }

        [Fact]
        public void FizzBuzzTest()
        {
            FizzBuzzGame a = new FizzBuzzGame();

            Assert.Equal("FizzBuzz", a.GetValue(15));
        }

        [Fact]
        public void FizzTest()
        {
            FizzBuzzGame a = new FizzBuzzGame();

            Assert.Equal("Fizz", a.GetValue(3));
        }

        [Fact]
        public void BuzzTest()
        {
            FizzBuzzGame a = new FizzBuzzGame();

            Assert.Equal("Buzz", a.GetValue(5));
        }

        [Fact]
        public void Numeric7Test()
        {
            FizzBuzzGame a = new FizzBuzzGame();

            Assert.Equal("7", a.GetValue(7));
        }

        [Fact]
        public void Numeric11Test()
        {
            FizzBuzzGame a = new FizzBuzzGame();

            Assert.Equal("11", a.GetValue(11));
        }

        [Fact]
        public void Numeric21Test()
        {
            FizzBuzzGame a = new FizzBuzzGame();

            Assert.Equal("Fizz", a.GetValue(21));
        }
    }
}
