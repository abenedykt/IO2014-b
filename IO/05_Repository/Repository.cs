using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Repository
{
    public class Repository :IRepository
    {
        public IEnumerable<string> GetAll()
        {
            throw new NotImplementedException();
        }


        public string Trim(IEnumerable<string> text)
        {
            throw new NotImplementedException();
        }
    }
}
