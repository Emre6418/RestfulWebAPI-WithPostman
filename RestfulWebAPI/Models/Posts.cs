using System.ComponentModel.DataAnnotations;

namespace RestfulWebAPI.Models
{
    public class Posts
    {
        public int UserId { get; set; }
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Title { get; set; }
        [Required]
        [MaxLength(500)]
        public string Body { get; set; } 
    }
}
