using ProjektFizzBuzz;
using Xunit;

namespace TestsFizzBuzz
{
    public class Tests
    {
        [Fact]
        public void CheckFizz()
        {
            var fizzBuzz = new FizzBuzz();

            Assert.Equal("Fizz", fizzBuzz.Game(3));
        }

        [Fact]
        public void CheckBuzz()
        {
            var fizzBuzz = new FizzBuzz();

            Assert.Equal("Buzz", fizzBuzz.Game(5));
        }

        [Fact]
        public void FizzBuzzTest()
        {
            var fizzBuzz = new FizzBuzz();

            Assert.Equal("FizzBuzz", fizzBuzz.Game(15));
        }

        [Fact]
        public void IsNumberTest()
        {
            var fizzBuzz = new FizzBuzz();

            Assert.Equal("2", fizzBuzz.Game(2));
        }
    }
}
