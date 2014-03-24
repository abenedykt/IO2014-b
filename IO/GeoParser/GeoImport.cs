using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeoParser
{
    public class GeoImport
    {
        private IGeoFileReader fileReader;
        private IGeoRepository repository;

        public GeoImport(IGeoFileReader fileReader, IGeoRepository repository)
        {
            this.fileReader = fileReader;
            this.repository = repository;
        }
        public List<string> Parse()
        {
            var parsed = new List<string>();
            var record = fileReader.GetRecords();
            var array = record.FirstOrDefault().Split(new[] { '\r', '\n' });
            var xs = new List<double>();
            var ys = new List<double>();
            parsed.Add(array[0]);
            parsed.Add(array[2].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0]);
            parsed.Add(array[2].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1]);
            for (int i = 6; i < 18; i = i + 2)
            {
                xs.Add(double.Parse(array[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1]));
                ys.Add(double.Parse(array[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[2]));
            }
            parsed.Add(xs.Max().ToString());
            parsed.Add(ys.Max().ToString());
            parsed.Add(xs.Min().ToString());
            parsed.Add(ys.Min().ToString());
            return parsed;
        }
    }
}
