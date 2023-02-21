using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Catalog.API.Entities
{
    [Table("Product", Schema = "dbo")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("category")]
        public string Category { get; set; }

        [Column("summary")]
        public string Summary { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("imageFile")]
        public string ImageFile { get; set; }

        [Column("price")]
        public decimal Price { get; set; }
    }
}
