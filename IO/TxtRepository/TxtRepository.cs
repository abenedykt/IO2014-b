using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repository
{
    public class TxtRepository : Repository.IRepository
    {
        private string _path;
        public TxtRepository(string path)
        {
            _path = path;
        }
        public IEnumerable<Event.IEvent> GetAllEvents()
        {
            var toReturn = new List<Event.IEvent>();
            using (var sr = new StreamReader(_path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var lin = line.Split(new[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
                    toReturn.Add(new Event.Event { Title = lin.FirstOrDefault(), Description = lin.LastOrDefault()});
                }
            }
            return toReturn;
        }
    }
}
