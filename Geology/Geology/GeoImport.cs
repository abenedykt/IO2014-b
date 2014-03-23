using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geology
{
    class GeoImport
    {
        private IGeoFileReader fileReader;
        private IGeoRepository repository;

        public GeoImport()
        {

        }

        public GeoImport(IGeoFileReader fileReader, IGeoRepository repository)
        {

            // TODO: Complete member initialization
            this.fileReader = fileReader;
            this.repository = repository;
        }
        public AreaStat parse()
        {

            List<String> Inputs = (List<String>)fileReader.GetRecords();
            string item = Inputs.FirstOrDefault();

            String[] lines = item.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            int VCount = int.Parse(lines[2]);
            AreaStat Parsed = new AreaStat { max_x = "0", max_y = "0", min_x = "1000000000", min_y = "1000000000" };
            Parsed.number = lines[0].Replace(" ","");
            {
                string[] line = lines[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Parsed.x = line[0];
                Parsed.y = line[1];
            }
            for (int i = 3; i < VCount + 2; i++)
            {
                string[] line = lines[i].Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
                if (float.Parse(line[1]) < float.Parse(Parsed.min_x)) Parsed.min_x = line[1];
                if (float.Parse(line[2]) < float.Parse(Parsed.min_y)) Parsed.min_y = line[2];
                if (float.Parse(line[1]) > float.Parse(Parsed.max_x)) Parsed.min_x = line[1];
                if (float.Parse(line[1]) > float.Parse(Parsed.max_y)) Parsed.min_y = line[2];
            }

            return Parsed;

        }

    }
}
