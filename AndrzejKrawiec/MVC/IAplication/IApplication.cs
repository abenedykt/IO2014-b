using System.Collections.Generic;

namespace IAplication
{
    public interface IApplication
    {
        IEnumerable<Event> Events();
    }

    public class Event
    {
        public string Name { get; set; }
    }
}
