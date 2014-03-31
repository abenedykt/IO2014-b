using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepo
{
  public interface IRepo
  {
      IEnumerable<Event> Getall();
  }

    public class Event
    {
    }
}
