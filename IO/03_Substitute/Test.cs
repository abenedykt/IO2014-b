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
        private const string Data2Fields = @"               1.1-800/128
        5544943.71        6532099.62         5544943.71        6532099.62 N  7
4
              1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7
              1-7880        5544908.34        6532098.97        5544908.34        6532098.97   0 N N  7
              1-7807        5544907.94        6532075.96        5544907.94        6532075.96   0 N N  7
              1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7

               1.1-1446/63
        5545268.52        6531690.89        5545268.52        6531690.89 N  7
5
              1-6990        5545327.57        6531678.07        5545327.57        6531678.07   0 N N  7
              1-7044        5545325.03        6531709.57        5545325.03        6531709.57   0 N N  7
              1-7048        5545324.77        6531712.12        5545324.77        6531712.12   0 N N  7
              1-7019        5545225.22        6531698.42        5545225.22        6531698.42   0 N N  7
              1-6990        5545327.57        6531678.07        5545327.57        6531678.07   0 N N  7";


        private const string Data = @"               1.1-800/128
        5544943.71        6532099.62         5544943.71        6532099.62 N  7
4
              1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7
              1-7880        5544908.34        6532098.97        5544908.34        6532098.97   0 N N  7
              1-7807        5544907.94        6532075.96        5544907.94        6532075.96   0 N N  7
              1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7";
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
        public void For1FieldReturnNumberOfPoints()
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            fileReader.Read("test.txt").Returns(Data);
            var geoImport = new GeoImport();
            var data = fileReader.Read("test.txt");

            Assert.Equal(4, geoImport.GetNumberOfPoints(data));
        }

        [Fact]
        public void For1FieldReturnXLocalizationOfField()
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            fileReader.Read("test.txt").Returns(Data);
            var geoImport = new GeoImport();
            var data = fileReader.Read("test.txt");

            Assert.Equal(6532099.62, geoImport.GetX(data));
        }

        [Fact]
        public void For1FieldReturnYLocalizationOfField()
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            fileReader.Read("test.txt").Returns(Data);
            var geoImport = new GeoImport();
            var data = fileReader.Read("test.txt");

            Assert.Equal(5544943.71, geoImport.GetY(data));
        }

        [Fact]
        public void ForOnePointReturnXLocalization()
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            fileReader.Read("test.txt").Returns(DataLine);
            var geoImport = new GeoImport();
            var data = fileReader.Read("test.txt");

            Assert.Equal(5544969.02, geoImport.GetXOfPoint(data));
        }

        [Fact]
        public void ForOnePointReturnYLocalization()
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            fileReader.Read("test.txt").Returns(DataLine);
            var geoImport = new GeoImport();
            var data = fileReader.Read("test.txt");

            Assert.Equal(6532117.26, geoImport.GetYOfPoint(data));
        }

        [Fact]
        public void For1FieldReturnMinX()
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            fileReader.Read("test.txt").Returns(Data);
            var geoImport = new GeoImport();
            var data = fileReader.Read("test.txt");

            Assert.Equal(5544907.94, geoImport.GetXMin(data));
        }

        [Fact]
        public void For1FieldReturnMinY()
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            fileReader.Read("test.txt").Returns(Data);
            var geoImport = new GeoImport();
            var data = fileReader.Read("test.txt");

            Assert.Equal(6532075.96, geoImport.GetYMin(data));
        }

        [Fact]
        public void For1FieldReturnMaxX()
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            fileReader.Read("test.txt").Returns(Data);
            var geoImport = new GeoImport();
            var data = fileReader.Read("test.txt");

            Assert.Equal(5544969.02, geoImport.GetXMax(data));
        }

        [Fact]
        public void For1FieldReturnMaxY()
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            fileReader.Read("test.txt").Returns(Data);
            var geoImport = new GeoImport();
            var data = fileReader.Read("test.txt");

            Assert.Equal(6532117.26, geoImport.GetYMax(data));
        }

        [Fact]
        public void For2FieldsReturn1Field()
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            fileReader.Read("test.txt").Returns(Data2Fields);
            var geoImport = new GeoImport();
            var data = fileReader.Read("test.txt");

            Assert.Equal(Data, geoImport.SplitFields(data).ElementAt(0)); 
        }
    }
}
