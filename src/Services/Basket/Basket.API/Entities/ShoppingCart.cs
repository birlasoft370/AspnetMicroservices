using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Basket.API.Entities
{
    [Table("ShoppingCart", Schema = "dbo")]
    public class ShoppingCart
    {
        [Column("UserName")]
        [Key]
        public string UserName { get; set; }

        [Column("cart_items")]
        public List<ShoppingCartItem> CartItems { get; set; } = new List<ShoppingCartItem>();

        public ShoppingCart(string userName)
        {
            UserName = userName;
        }

        public ShoppingCart()
        {
        }

        public decimal TotalPrice
        {
            get
            {
                decimal totalprice = 0;
                foreach (var item in CartItems)
                {
                    totalprice += item.Price * item.Quantity;
                }
                return totalprice;
            }
        }
    }
}
