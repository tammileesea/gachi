using System;
namespace gachiBlazorServer.Data.Models
{
	public class OrganizationAddress
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string StreetLineOne { get; set; }
		public string StreetLineTwo { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string ZipCode { get; set; }

		public OrganizationAddress(string name, string streetLineOne, string streetLineTwo, string city, string state, string zipCode)
		{
			Name = name;
			StreetLineOne = streetLineOne;
			StreetLineTwo = streetLineTwo;
			City = city;
			State = state;
			ZipCode = zipCode;
		}
	}
}

