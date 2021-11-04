using System;
using System.ComponentModel.DataAnnotations;

namespace SR2POS.Models
{
    public class Customer
    {
        [Key]
        public Guid CustomerId { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name ="Customer Name")]
        public string CustomerName { get; set; }
        [Phone]
        [MaxLength(15)]
        public string Mobile { get; set; }
        [DataType(DataType.MultilineText)]
        [MaxLength(100)]
        public string Address { get; set; }
        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }
    }
}
