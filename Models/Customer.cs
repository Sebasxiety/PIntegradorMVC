using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PIntegradorMVC.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;

        public ICollection<Order>? Orders { get; set; }
    }
}
