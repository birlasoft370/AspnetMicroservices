using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Discount.API.Entities
{
    [Table("Coupon",Schema ="dbo")]
    public class Coupon
    {
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("ProductName")]
        public string ProductName { get; set; }
        [Column("Description")]
        public string Description { get; set; }
        [Column("Amount")]
        public int Amount { get; set; }
    }
}
