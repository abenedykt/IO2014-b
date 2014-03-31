using System.Collections.Generic;


namespace IApplication
{
    public interface IApplication
    {
        IEnumerable<string> Events { get; set; }
    }
}
