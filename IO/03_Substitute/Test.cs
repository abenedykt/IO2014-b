using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NSubstitute;
using NSubstitute.Core;
using Xunit;

namespace _03_Substitute
{
    public class Test
    {
        #region data
        private const string Data = @"               1.1-800/128
        5544943.71        6532099.62         5544943.71        6532099.62 N  7
7
              1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7
              1-7880        5544908.34        6532098.97        5544908.34        6532098.97   0 N N  7
              1-7807        5544907.94        6532075.96        5544907.94        6532075.96   0 N N  7
              1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7
";
        private const string DataLine = "              1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7";

        #endregion

        [Fact]
        public void ForFieldReturnFieldNumber()
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            fileReader.Read("test.txt").Returns(Data);
            var geoImport = new GeoImport();
            var data = fileReader.Read("test.txt");

            Assert.Equal("1.1-800/128", geoImport.GetFieldNumber(data));
        }

        [Fact]
        public void ReturnNumberOfPoints()
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            fileReader.Read("test.txt").Returns(Data);
            var geoImport = new GeoImport();
            var data = fileReader.Read("test.txt");

            Assert.Equal(7, geoImport.GetNumberOfPoints(data));
        }

        [Fact]
        public void ReturnXLocalizationOfField()
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            fileReader.Read("test.txt").Returns(Data);
            var geoImport = new GeoImport();
            var data = fileReader.Read("test.txt");

            Assert.Equal(6532099.62, geoImport.GetX(data));
        }

        [Fact]
        public void ReturnYLocalizationOfField()
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            fileReader.Read("test.txt").Returns(Data);
            var geoImport = new GeoImport();
            var data = fileReader.Read("test.txt");

            Assert.Equal(5544943.71, geoImport.GetY(data));
        }

        [Fact]
        public void ReturnXLocalizationForPoint()
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            fileReader.Read("test.txt").Returns(DataLine);
            var geoImport = new GeoImport();
            var data = fileReader.Read("test.txt");

            Assert.Equal(5544969.02, geoImport.GetXOfPoint(data));
        }

        [Fact]
        public void ReturnYLocalizationForPoint()
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            fileReader.Read("test.txt").Returns(DataLine);
            var geoImport = new GeoImport();
            var data = fileReader.Read("test.txt");

            Assert.Equal(6532117.26, geoImport.GetYOfPoint(data));
        }

        [Fact]
        public void ReturnMinX()
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            fileReader.Read("test.txt").Returns(Data);
            var geoImport = new GeoImport();
            var data = fileReader.Read("test.txt");

            Assert.Equal(5544907.94, geoImport.GetXMin(data));
        }

        [Fact]
        public void ReturnMinY()
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            fileReader.Read("test.txt").Returns(Data);
            var geoImport = new GeoImport();
            var data = fileReader.Read("test.txt");

            Assert.Equal(6532075.96, geoImport.GetYMin(data));
        }

        [Fact]
        public void ReturnMaxX()
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            fileReader.Read("test.txt").Returns(Data);
            var geoImport = new GeoImport();
            var data = fileReader.Read("test.txt");

            Assert.Equal(5544969.02, geoImport.GetXMax(data));
        }

        [Fact]
        public void ReturnMaxY()
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            fileReader.Read("test.txt").Returns(Data);
            var geoImport = new GeoImport();
            var data = fileReader.Read("test.txt");

            Assert.Equal(6532117.26, geoImport.GetYMax(data));
        }
    }
}
