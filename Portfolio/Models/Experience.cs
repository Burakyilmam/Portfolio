using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class Experience
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
