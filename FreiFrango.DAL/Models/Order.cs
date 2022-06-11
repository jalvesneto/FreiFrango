using System.ComponentModel.DataAnnotations;

namespace FreiFrango.DAL.Models
{
    public class Order
    {
        [Required]
        public long Id { get; set; }

        [Required]
        public long UserId { get; set; }

        public enum status 
        {
            AguardandoConfirmaçao = 0,
            Confirmado = 1,
            EmSeparacao = 2,
            AguardandoEntregador = 3,
            EmTransporte = 4,
            Concluido = 5,
            Cancelado = 6
        }

        [Required]
        public decimal ValorTotal { get; set; }

        [Required]
        public List<ProdutosOrder> ListProducts { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public DateTime LastUpdate { get; set; }

        public DateTime ConcludeAt { get; set; }
    }
}
