using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _06
{
    public class Tests
    {
        [Fact]
        public void GetAOfSquare()
        {
            var shape = new Square();
            shape.A = 5;

            Assert.Equal(shape.A, 5);
        }

        [Fact]
        public void CalculateFieldOfSquare()
        {
            var shape = new Square();
            shape.A = 5;

            Assert.Equal(shape.GetField(), 25);
        }

        [Fact]
        public void CalculateCircuitOfSquare()
        {
            var shape = new Square();
            shape.A = 5;

            Assert.Equal(shape.GetCircuit(), 20);
        }

        [Fact]
        public void GetAOfRectangle()
        {
            var shape = new Rectangle();
            shape.A = 5;

            Assert.Equal(shape.A, 5);
        }

        [Fact]
        public void GetBOfRectangle()
        {
            var shape = new Rectangle();
            shape.B = 6;

            Assert.Equal(shape.B, 6);
        }

        [Fact]
        public void CalculateFieldOfRectangle()
        {
            var shape = new Rectangle();
            shape.A = 5;
            shape.B = 6;

            Assert.Equal(shape.GetField(), 30);
        }

        [Fact]
        public void CalculateCircuitOfRectangle()
        {
            var shape = new Rectangle();
            shape.A = 5;
            shape.B = 6;

            Assert.Equal(shape.GetCircuit(), 22);
        }
    }
}
