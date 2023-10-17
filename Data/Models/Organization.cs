using System;
namespace gachiBlazorServer.Data.Models
{
	public class Organization
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<OrganizationAddress> Addresses { get; set; }
		public List<User> Members { get; set; }

		public Organization()
		{
		}
	}
}

