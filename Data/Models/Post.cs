namespace gachiBlazorServer.Data.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string PostText { get; set; } 

        public List<string>? CategoryTags { get; set; }

        public List<string> LocationTags{ get; set; }

        public PostType Type { get; set; }

        public int? VoteCount { get; set; }

        public User? User { get; set; }
    }
}
