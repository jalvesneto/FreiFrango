using System.ComponentModel.DataAnnotations;

namespace FreiFrango.DAL.Models
{
    public class BuyLater
    {
        [Required]
        public long Id { get; set; }

        [Required]
        public long UserId { get; set; }

        public List<ProdutosOrder> Produtos { get; set; }
    }
}