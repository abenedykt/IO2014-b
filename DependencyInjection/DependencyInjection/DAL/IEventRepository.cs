using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjection.Models;

namespace DependencyInjection.DAL
{
    public interface IEventRepository
    {
        IList<Event> GetEvents();
    }
}
