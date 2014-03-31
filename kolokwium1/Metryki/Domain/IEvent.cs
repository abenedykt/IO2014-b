using System;
using System.Collections.Generic;

namespace Metryki.Domain
{
	public interface IEvent
	{
		IEnumerable<IPerson> Attendees { get; set; }
		DateTime StartDate { get; set; }
		DateTime EndDate { get; set; }
	}
}