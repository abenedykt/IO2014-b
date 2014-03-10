using Xunit;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        [Fact]
        public void TestNa3()
        {
            var game = new Game();
            var r = game.Say(3);
            Assert.Equal("Fizz", r);
        }
        [Fact]
        public void TestNa5()
        {
            var game = new Game();
            var r = game.Say(5);
            Assert.Equal("Buzz", r);
        }
        [Fact]
        public void TestNa15()
        {
            var game = new Game();
            var r = game.Say(15);
            Assert.Equal("Fizz-Buzz", r);
        }
        [Fact]
        public void TestNaPodzielnosc()
        {
            var game = new Game();
            var r = game.Say(8);
            Assert.Equal(string.Empty, r);
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
