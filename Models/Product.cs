using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yat.NetCore31.Spa.Models
{
    [Table("product")]
    public class Product
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("name")]
        public string Name { get; set; }
        
        [Column("description")]
        public string Description { get; set; }
        
        [Column("price")]
        public decimal Price { get; set; }
        
        // [Column("created_by")]
        // public string CreatedBy { get; set; }
        
        // [Column("created_on")]
        // public DateTime CreatedOn { get; set; }
    }
}