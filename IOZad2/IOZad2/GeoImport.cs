using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOZad2
{
    public class GeoImport
    {
        FileReader reader;
        IParser parser;
        IRepository repository;

        GeoImport(FileReader reader, IParser parser, IRepository repository)
        {
            this.reader = reader;
            this.parser = parser;
            this.repository = repository;
        }

        void DOWORK()
        {
            foreach (var line in reader.PobierzDzialke())
            {

                var dzialka = parser.Parse(line);
                repository.DodajDzialke(dzialka);
            }
        }
    }
}
