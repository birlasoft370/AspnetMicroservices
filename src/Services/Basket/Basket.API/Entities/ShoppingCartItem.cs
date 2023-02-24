using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Basket.API.Entities
{
    [Table("ShoppingCartItem")]
    public class ShoppingCartItem
    {
        [Column("CartItemId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartItemId { get; set; }
        public int Quantity { get; set; }
        public string Color { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ProductId { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public string ShoppingCartUserName { get; set; } = string.Empty;
    }
}
