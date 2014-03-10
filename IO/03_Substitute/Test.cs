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
        string _data = @"               1.1-800/128
        5544943.71        6532099.62         5544943.71        6532099.62 N  7
7
              1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7
              1-7880        5544908.34        6532098.97        5544908.34        6532098.97   0 N N  7
              1-7807        5544907.94        6532075.96        5544907.94        6532075.96   0 N N  7
              1-7856        5544928.59        6532085.45        5544928.59        6532085.45   0 N N  7
              1-7881        5544975.70        6532098.40        5544975.70        6532098.40   0 N N  7
              1-7907        5544972.66        6532107.54        5544972.66        6532107.54   0 N N  7
              1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7
";
        #endregion

        [Fact]
        public void ForFieldReturnFieldNumber()
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            fileReader.Read("test.txt").Returns(_data);
            var repository = Substitute.For<IGeoRepository>();
            var geoImport = new GeoImport();
            var data = fileReader.Read("test.txt");

            Assert.Equal("1.1-800/128", geoImport.GetFieldNumber("test.txt"));
        }

    }
}
