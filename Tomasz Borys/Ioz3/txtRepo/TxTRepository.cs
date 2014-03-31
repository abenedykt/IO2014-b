using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRepo;

namespace txtRepo
{
    public class TxTRepository : Irepository
    {
        IEnumerable<String> GetEvents()
        {
            List<String> lista = new List<string>() {"Piwo", "Kino", "Sen", "Obiad" };
            return lista as IEnumerable<String>;
        }
    }
}
