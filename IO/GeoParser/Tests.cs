using System.Collections.Generic;
using NSubstitute;
using Xunit;

namespace GeoParser
{
    public class Tests
    {
        [Fact]
        public void GetValuesTest()
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            var repository = Substitute.For<IGeoRepository>();
            fileReader.GetRecords().Returns(new List<string> {Miasta.MiastoPierwsze});


            var import = new GeoImport(fileReader, repository);

            var returns = import.Parse();

            Assert.Equal("1.1-800/128", returns[0]); //nrDzialki
            Assert.Equal("5544943.71", returns[1]); //x
            Assert.Equal("6532099.62", returns[2]); //y
            Assert.Equal("5544975.7", returns[3]);
            Assert.Equal("6532117.26", returns[4]);
        }
    }
}
