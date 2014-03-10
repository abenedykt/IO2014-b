using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace _01_TDD2
{
    public class Fis
    {
        [Fact]
        public void ForThreeShowFis()
        {
            var game = new Game();
            var r = game.Say(3);

            Assert.Equal("Fiss", r);
        }

        [Fact]
        public void ForFiveShowBus()
        {
            var game = new Game();

            var r = game.Say(5);
            Assert.Equal("Buzz", r);
        }

        [Fact]
        public void ForFifteenShowFisBus()
        {
            var game = new Game();

            var r = game.Say(15);
            Assert.Equal("FissBuzz", r);
        }

        [Fact]
        public void ForMaxIntShowMaxInt()
        {
            var game = new Game();

            var r = game.Say(int.MaxValue);
            Assert.Equal("MaxInt", r);
        }

        [Fact]
        public void ForMinIntShowMinInt()
        {
            var game = new Game();

            var r = game.Say(int.MinValue);
            Assert.Equal("MinInt", r);
        }

        [Fact]
        public void ForDifrentThenThreeAndFiveShowNumber()
        {
            var game = new Game();

            var r = game.Say(16);
            Assert.Equal("16", r);
        }
    }
}
