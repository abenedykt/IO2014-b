using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace ConsoleApplication13
{
    public class ShapeTest
    {
        [Fact]
        public void SquareTestCorrect()
        {
            Shape s = new Square
            {
                x = 10,
                y = 5,
            };
            s.CalculateCircuite().Should().Be(30);
        }
        [Fact]
        public void RectangleTestCorrect()
        {
            Shape s = new Rectangle
            {
                x = 10,
            };
            s.CalculateCircuite().Should().Be(40);
        }
    }
}
