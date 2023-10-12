using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class Language
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public string elementId { get; set; }
    }
}
