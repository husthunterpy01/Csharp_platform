using FluentAPISample.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FluentAPISample.Data
{
    [Table("Type")]
    public class Type
    {
        [Key]
        public int TypeId { get; set; }


        public string TypeName { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
    }
}
