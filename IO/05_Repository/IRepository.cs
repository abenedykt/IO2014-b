using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Repository
{
    public interface IRepository
    {
        IEnumerable<string> GetAll();

        string Trim(IEnumerable<string> text);
    }
}
