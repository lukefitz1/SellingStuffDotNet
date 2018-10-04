using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SellingStuffDotNet.Models
{
    [Table("Products")]
    public class Product
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Sku { get; set; }
        [Required]
        public double Price { get; set; }
        public double SpecialPrice { get; set; }
        [Required]
        public int Inventory { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        [Required]
        public double Weight { get; set; }
        [Required]
        public bool Status { get; set; }
        public string MainImage { get; set; }
    }
}