using System.Collections.Generic;

namespace Repository
{
    public class Repository : IRepository.IRepository
    {
        public IEnumerable<string> GetAllEvents()
        {
            return new List<string> {"Jeden", "Dwa", "Trzy"};
        }
    }
}
