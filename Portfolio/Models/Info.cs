using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class Info
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string WhatsappUrl { get; set; }
        public string LinkedinUrl { get; set; }
        public string GithubUrl { get; set; }
        public string YoutubeUrl { get; set; }
        public string ImageUrl { get; set; }
    }
}
