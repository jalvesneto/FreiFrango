using System.ComponentModel.DataAnnotations;

namespace FreiFrango.DAL.Models
{
    public class ProdutosOrder
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public long IdProduto { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public bool IsByKg { get; set; }

        [Required]
        public int Quantidade { get; set; }

    }
}
