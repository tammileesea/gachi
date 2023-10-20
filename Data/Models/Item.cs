using System;
namespace gachiBlazorServer.Data.Models
{
	public class Item
	{
		public int Id { get; set; }
		public string Name {get; set;}
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public Item()
		{
		}
	}
}

