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

        public GeoImport(IGeoFileReader fileReader, IGeoRepository repository)
        {
            // TODO: Complete member initialization
            this.fileReader = fileReader;
            this.repository = repository;
        }
        public void parse()
        {
            List<String> Inputs = (List<String>)fileReader.GetRecords();
            foreach (string item in Inputs)
            {
                String[] lines = item.Split('\n');
            }
        }

    }
}
