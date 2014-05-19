using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjection.Models
{
    public class Event
    {
        public Guid Guid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
    }
}