using System.ComponentModel.DataAnnotations;

namespace DateMe.Models
{
    public class Application
    {
        [Key]
        public int ApplicationID { get; set; }
        public string Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }

        [Required]  
        public bool Edited { get; set; }
        public string LentTo { get; set; }

        public string Notes { get; set; }
    }
}
