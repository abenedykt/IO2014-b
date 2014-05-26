using projekt1;
using Xunit;

namespace projekt2_testy
{
    public class FizzBuzzTests
    {
        [Fact]
        public void FizzTest()
        {
            var fizzBuzz = new FizzBuzz();

            Assert.Equal("Fizz", fizzBuzz.GetValue(3));
        }

        [Fact]
        public void BuzzTest()
        {
            var fizzBuzz = new FizzBuzz();

            Assert.Equal("Buzz", fizzBuzz.GetValue(5));
        }

        [Fact]
        public void FizzBuzzTest()
        {
            var fizzBuzz = new FizzBuzz();

            Assert.Equal("FizzBuzz", fizzBuzz.GetValue(15));
        }

        [Fact]
        public void IsNumberTest()
        {
            var fizzBuzz = new FizzBuzz();

            Assert.Equal("2", fizzBuzz.GetValue(2));
        }
    }
}
