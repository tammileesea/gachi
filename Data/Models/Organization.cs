using System;
namespace gachiBlazorServer.Data.Models
{
	public class Organization
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<OrganizationAddress> Addresses { get; set; }
		public List<User> Members { get; set; }

		//Tammi's note- I'm not sure we need a Location property since we have addresses.
		//An edge case is that an org can maybe have locations in other cities, but for now i think we can safely assume that they're all in one city?
		public string Location { get; set;  } // Possibly the city where the Organization is located 

		public Organization()
		{
		}
	}
}

