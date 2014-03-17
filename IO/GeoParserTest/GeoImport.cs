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
                tempList.Add("x", xy[0].Trim());
                tempList.Add("y", xy[1].Trim());
                double minx = Double.MaxValue, miny = Double.MaxValue, maxx = 0, maxy = 0;
                for (int i = 3; i < int.Parse(linia[2].Trim())+3; i++)
                {
                    var minmax = linia[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    minx = minx > Convert.ToDouble(minmax[1].Trim()) ? Convert.ToDouble(minmax[1].Trim()) : minx;
                    miny = miny > Convert.ToDouble(minmax[2].Trim()) ? Convert.ToDouble(minmax[2].Trim()) : miny;
                    maxx = maxx < Convert.ToDouble(minmax[3].Trim()) ? Convert.ToDouble(minmax[3].Trim()) : maxx;
                    maxy = maxy < Convert.ToDouble(minmax[4].Trim()) ? Convert.ToDouble(minmax[4].Trim()) : maxy;
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
