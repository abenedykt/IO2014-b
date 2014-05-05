using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractRepo;
using Repo;

namespace AbstractInterface
{
    public interface IPersonInt
    {
        IPersonRepo AP1 { get; set; }
        PersonRepo P1 { get; set; }
    }
}
