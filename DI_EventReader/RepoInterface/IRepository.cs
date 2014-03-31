using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoInterface
{
    public interface IRepository
    {
        IEnumerable<string> GetAll();
    }
}
