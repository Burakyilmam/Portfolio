using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class Education
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
