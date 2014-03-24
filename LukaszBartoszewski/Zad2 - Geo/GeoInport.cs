using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad2
{
    public class GeoImport
    {
        private IGeoFileReader fileReader;
        private IGeoRepository repository;

        public GeoImport(IGeoFileReader fileReader, IGeoRepository repository)
        {
            // TODO: Complete member initialization
            this.fileReader = fileReader;
            this.repository = repository;
        }

        public DefaultTown Parse()
        {
            var defaultTown = new DefaultTown();

            var tabRecords = defaultTown.defaultTown.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            var getXandY = defaultTown.defaultTown.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);

            var x = new List<double>();
            var y = new List<double>();

            for (var i = 3; i < tabRecords.Length; i++)
            {
                var tempXy = tabRecords[i].Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);
                x.Add(Convert.ToDouble(tempXy[1]));
                y.Add(Convert.ToDouble(tempXy[2]));
            }

            defaultTown.GeoNumber = tabRecords[0];
            defaultTown.x = Convert.ToDouble(getXandY[1]);
            defaultTown.y = Convert.ToDouble(getXandY[2]); 
            defaultTown.maxX = x.Max();
            defaultTown.maxY = y.Max();
            defaultTown.minX = x.Min();
            defaultTown.minY = y.Min();
            return defaultTown;
        }
    }
}
