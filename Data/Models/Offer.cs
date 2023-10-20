using System;
namespace gachiBlazorServer.Data.Models
{
	public class Offer
	{
		public int Id { get; set; }
		public User OfferedBy { get; set; }
		public List<Item> Items { get; set; }
        //if status is archived, bool will be false
        public Boolean IsActive { get; set; }
        public OfferStatus Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public Offer()
		{
		}
	}
}

