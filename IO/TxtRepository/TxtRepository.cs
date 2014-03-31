using System.Collections.Generic;
using System.IO;

namespace Repository
{
    public class TxtRepository : Repository.IRepository
    {
        private string _path;
        public TxtRepository(string path)
        {
            _path = path;
        }
        public IEnumerable<string> GetAllEvents()
        {
            var toReturn = new List<string>();
            using (var sr = new StreamReader(_path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    toReturn.Add(line);
                }
            }
            return toReturn;
        }
    }
}
