using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispatchService.Common
{
	public interface IRequest
	{
		string FirstName { get; set; }
		string LastName { get; set; }
		DateTime DateTimeRequested { get; set; }
		DateTime PickupDateTime { get; set; }
		DateTime DropOffDateTime { get; set; }
		// -- Multiple stop locations
	}
}
