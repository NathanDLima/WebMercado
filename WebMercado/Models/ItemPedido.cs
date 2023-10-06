using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMercado.Models
{
    [Table("ItemPedido")]
    public class ItemPedido
    {
        [Key]
        public int Id { get; set; }

        public int PedidoId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public double ValorTotal { get; set; }

        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
    }
}
