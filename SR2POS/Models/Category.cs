using System;
using System.ComponentModel.DataAnnotations;

namespace SR2POS.Models
{
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; }
        [MaxLength(50)]
        [Required]
        [Display(Name ="Category Name")]
        public string CategoryName { get; set; }
    }
}
