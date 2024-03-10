using System.ComponentModel.DataAnnotations;

namespace DateMe.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public bool Edited { get; set; }
        [Required]
        public bool CopiedToPlex { get; set; }
    }
}
