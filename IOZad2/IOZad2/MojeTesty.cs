using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IOZad2
{
    public class MojeTesty
    {
        [Fact]
        public void DzialkaPusta()
        {
            Dzialka dzialka = new Dzialka();
            Assert.Equal(null, dzialka.Srodek);
            Assert.Equal(0, dzialka.Wierzcholki.Count());
        }

        [Fact]
        public void DzialkaZSrodkiem()
        {
            Dzialka dzialka = new Dzialka();
            dzialka.Srodek = new Punkt();

            Assert.NotEqual(null, dzialka.Srodek);
            Assert.Equal(0, dzialka.Wierzcholki.Count());
        }

        [Fact]
        public void DzialkaZWierzcholkiem()
        {
            Dzialka dzialka = new Dzialka();
            dzialka.DodajPunkt(new Punkt());

            Assert.Equal(1, dzialka.Wierzcholki.Count());
        }

        [Fact]
        public void DzialkaZSrodekiem10i20()
        {
            Dzialka dzialka = new Dzialka();
            dzialka.Srodek = new Punkt() { X = 10, Y = 20 };

            Assert.Equal(10, dzialka.Srodek.X);
            Assert.Equal(20, dzialka.Srodek.Y);
        }

        [Fact]
        public void FileReaderCorrect()
        {
            var reader = Substitute.For<FileReader>();

            reader.PobierzDzialke().First().Returns(
                @"               1.1-800/128
                 5544943.71        6532099.62         5544943.71        6532099.62 N  7
                 7
                 1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7
                 1-7880        5544908.34        6532098.97        5544908.34        6532098.97   0 N N  7
                 1-7807        5544907.94        6532075.96        5544907.94        6532075.96   0 N N  7
                 1-7856        5544928.59        6532085.45        5544928.59        6532085.45   0 N N  7
                 1-7881        5544975.70        6532098.40        5544975.70        6532098.40   0 N N  7
                 1-7907        5544972.66        6532107.54        5544972.66        6532107.54   0 N N  7
                 1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7"
            );

            Assert.Equal(
                @"               1.1-800/128
                 5544943.71        6532099.62         5544943.71        6532099.62 N  7
                 7
                 1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7
                 1-7880        5544908.34        6532098.97        5544908.34        6532098.97   0 N N  7
                 1-7807        5544907.94        6532075.96        5544907.94        6532075.96   0 N N  7
                 1-7856        5544928.59        6532085.45        5544928.59        6532085.45   0 N N  7
                 1-7881        5544975.70        6532098.40        5544975.70        6532098.40   0 N N  7
                 1-7907        5544972.66        6532107.54        5544972.66        6532107.54   0 N N  7
                 1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7"
            , reader.PobierzDzialke().First());
        }

        [Fact]
        public void TworzenieDzialkiZDzialkaParser()
        {
            var parser = new DzialkaParser();

            var dzialka = parser.Parse(
                @"               1.1-800/128
                 5544943.71        6532099.62         5544943.71        6532099.62 N  7
                 7
                 1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7
                 1-7880        5544908.34        6532098.97        5544908.34        6532098.97   0 N N  7
                 1-7807        5544907.94        6532075.96        5544907.94        6532075.96   0 N N  7
                 1-7856        5544928.59        6532085.45        5544928.59        6532085.45   0 N N  7
                 1-7881        5544975.70        6532098.40        5544975.70        6532098.40   0 N N  7
                 1-7907        5544972.66        6532107.54        5544972.66        6532107.54   0 N N  7
                 1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7");
            Assert.Equal(true, DoubleIsEqual(5544943.71, dzialka.Srodek.X));
            Assert.Equal(true, DoubleIsEqual(6532099.62, dzialka.Srodek.Y));

            Assert.Equal(true, DoubleIsEqual(5544969.02, dzialka.Wierzcholki[0].X));
            Assert.Equal(true, DoubleIsEqual(6532117.26, dzialka.Wierzcholki[0].Y));

            Assert.Equal(7, dzialka.Wierzcholki.Count);
        }
        public bool DoubleIsEqual(double a, double b)
        {
            return Math.Abs(a - b) < 0.001;
        }
    }
}
