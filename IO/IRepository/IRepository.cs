using System.Collections.Generic;

namespace IRepository
{
    public interface IRepository
    {
        IEnumerable<string> GetAllEvents();
    }
}
