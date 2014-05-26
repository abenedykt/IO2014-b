using ProjektPierwszy;
using Xunit;

namespace ProjektDrugi
{
    public class Tests
    {
        [Fact]
        public void TestFor3()
        {
            var game = new Game();
            var r = game.Say(3);
            Assert.Equal("Fizz", r);
        }

        [Fact]
        public void TestFor5()
        {
            var game = new Game();
            var r = game.Say(5);
            Assert.Equal("Buzz", r);
        }

        [Fact]
        public void TestFor3And5()
        {
            var game = new Game();
            var r = game.Say(60);
            Assert.Equal("Fizz-Buzz", r);
        }

        [Fact]
        public void TestForNotDivide()
        {
            var game = new Game();
            var r = game.Say(8);
            Assert.Equal("8", r);
        }
    }
}
