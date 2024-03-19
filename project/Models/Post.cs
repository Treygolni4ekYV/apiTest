using System.ComponentModel.DataAnnotations;

namespace project.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
}