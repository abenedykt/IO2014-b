﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public interface IEvent
    {
        string Title { get; set; }
        string Description { get; set; }
    }
}
