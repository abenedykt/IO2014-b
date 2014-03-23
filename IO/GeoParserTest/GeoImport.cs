using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeoParserTest
{
    class GeoImport
    {
        private IGeoRepository repository;
        private IGeoFileReader fileReader;

        public GeoImport(IGeoFileReader fileReader, IGeoRepository repository)
        {
            this.fileReader = fileReader;
            this.repository = repository;
        }

        public Dictionary<string, object> Parse()
        {
            var tempList = new Dictionary<string, object>();
            
            var list = fileReader.GetRecords();
            foreach (var item in list)
            {
                var linia = item.Split(new string[] {"\n"}, StringSplitOptions.RemoveEmptyEntries);
                tempList.Add("nrDzialki", linia[0].Trim());
                var xy = linia[1].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                tempList.Add("x", double.Parse(xy[0].Replace('.',',')));
                tempList.Add("y", double.Parse(xy[1].Replace('.', ',')));
                double minx = Double.MaxValue, miny = Double.MaxValue, maxx = 0, maxy = 0;
                for (int i = 3; i < int.Parse(linia[2].Trim())+3; i++)
                {
                    var minmax = linia[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    double currMinX = double.Parse(minmax[1].Replace('.',','));
                    double currMinY = double.Parse(minmax[2].Replace('.', ','));
                    double currMaxX = double.Parse(minmax[3].Replace('.', ','));
                    double currMaxY = double.Parse(minmax[4].Replace('.', ','));
                    minx = minx > currMinX ? currMinX : minx;
                    miny = miny > currMinY ? currMinY : miny;
                    maxx = maxx < currMaxX ? currMaxX : maxx;
                    maxy = maxy < currMaxY ? currMaxY : maxy;
                }
                tempList.Add("minx", minx);
                tempList.Add("miny", miny);
                tempList.Add("maxx", maxx);
                tempList.Add("maxy", maxy);
            }
            return tempList;
        }
    }
}
