using System.ComponentModel.DataAnnotations;

namespace FreiFrango.DAL.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public int Status { get; set; }

        [Required]
        public bool IsAdmin { get; set; }

    }
}
