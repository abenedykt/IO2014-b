using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using Xunit;

namespace Geology
{
    public class Tests
    {
        [Fact]
        public void TestFirstRecord()
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            var repository = Substitute.For<IGeoRepository>();
            var import = new GeoImport(fileReader, repository);
            List<string> LS = new List<string>();
            LS.Add(@"               1.1-800/128
        5544943.71        6532099.62         5544943.71        6532099.62 N  7
7
              1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7
              1-7880        5544908.34        6532098.97        5544908.34        6532098.97   0 N N  7
              1-7807        5544907.94        6532075.96        5544907.94        6532075.96   0 N N  7
              1-7856        5544928.59        6532085.45        5544928.59        6532085.45   0 N N  7
              1-7881        5544975.70        6532098.40        5544975.70        6532098.40   0 N N  7
              1-7907        5544972.66        6532107.54        5544972.66        6532107.54   0 N N  7
              1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7");
            fileReader.GetRecords().Returns(LS);
            AreaStat DesiredValue = new AreaStat { number = "1.1-800/128", x = "5544943.71", y = "6532099.62", min_x = "5544907.94", min_y = "6532075.96", max_x = "5544975.70", max_y = "6532117.26" };
            GeoImport GI = new GeoImport(fileReader, repository);

            AreaStat result = import.parse();
            Assert.Equal(result.number, DesiredValue.number);
            Assert.Equal(result.x, DesiredValue.x);
            Assert.Equal(result.y, DesiredValue.y);
            Assert.Equal(result.max_x, DesiredValue.max_x);
            Assert.Equal(result.max_y, DesiredValue.max_y);
            Assert.Equal(result.min_x, DesiredValue.min_x);
            Assert.Equal(result.min_y, DesiredValue.min_y);
        }

    }
}
