using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using NSubstitute;

namespace Zad2
{
    public class GeoTests
    {
        [Fact]
        public void CheckIfFileReaderReturnsCorrectString()
        {
            var fileReader = Substitute.For<IGeoFileReader>();

            var repository = Substitute.For<IGeoRepository>();

            var import = new GeoImport(fileReader, repository);

            var defaultTown = import.Parse();

            fileReader.GetRecords().Returns(new List<string> { defaultTown.defaultTown });
            Assert.Equal(fileReader.GetRecords().First(), defaultTown.defaultTown);
        }

        [Fact]
        public void CheckIfParserReturnsCorrectValues()
        {
            var fileReader = Substitute.For<IGeoFileReader>();

            var repository = Substitute.For<IGeoRepository>();

            var import = new GeoImport(fileReader, repository);

            var defaultTown = import.Parse();

            Assert.Equal(defaultTown.GeoNumber, "1.1-800/128");
            Assert.Equal(defaultTown.x, 5544943.71);
            Assert.Equal(defaultTown.y, 6532099.62);
            Assert.Equal(defaultTown.maxX, 5544975.7);
            Assert.Equal(defaultTown.maxY, 6532117.26);
            Assert.Equal(defaultTown.minX, 5544907.94);
            Assert.Equal(defaultTown.minY, 6532075.96);
        }
    }
}
