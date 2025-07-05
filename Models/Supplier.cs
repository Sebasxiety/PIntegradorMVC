using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PIntegradorMVC.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        public ICollection<Product>? Products { get; set; }
    }
}
