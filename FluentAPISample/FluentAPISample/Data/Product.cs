using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FluentAPISample.Data
{
    [Table("Product")]
    public class Product
    {    
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Range(0, double.MaxValue)]
        public double Price { get; set; }
        public byte Discount { get; set; }
        public int? TypeId { get; set; }
        [ForeignKey("TypeId")]
        public Type type { get; set; }

        public ICollection<DetailedOrder> DetailedOrders { get; set; }
        public Product()
        {
            DetailedOrders = new List<DetailedOrder>(); // Empty list instead of null list
        }
    }
}
