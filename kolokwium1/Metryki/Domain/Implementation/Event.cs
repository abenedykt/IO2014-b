using System;
using System.Collections.Generic;

namespace Metryki.Domain.Implementation
{
	public class Event : IEvent
	{
		public IEnumerable<IPerson> Attendees { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
	}
}