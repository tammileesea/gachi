using System;
namespace gachiBlazorServer.Data.Models
{
	public class OrganizationAddress
	{
		//in DB schema, we will need Org ID as a foreign key
		public int Id { get; set; }
		public string Name { get; set; }
		public string StreetLineOne { get; set; }
		public string StreetLineTwo { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string ZipCode { get; set; }
		public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

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

