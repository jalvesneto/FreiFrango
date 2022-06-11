using System.ComponentModel.DataAnnotations;

namespace FreiFrango.DAL.Models
{
    public class Produto
    {
        [Required]
        public long Id { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public bool IsByKg { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

    }
}
