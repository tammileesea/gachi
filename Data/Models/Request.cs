using System;
namespace gachiBlazorServer.Data.Models
{
	public class Request
	{
        public int Id { get; set; }
        public List<Item> Items{ get; set; }
        public int UpvoteCount { get; set; }
        public User? RequestedBy { get; set; }
        public string RequesterName { get; set; }
        //if status is archived, bool will be false
        public bool IsActive { get; set; }
        public RequestStatus Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public Request()
		{
		}
	}
}

