using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Models
{
    public class Products
    {
        [Key]
        [Column("ProductId")]
        public int ProductId { get; set; }

        [Column("ProductTypeId")]
        public int ProductTypeId { get; set; }

        [Required(ErrorMessage = "Product is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum length should not exceed 100 characters")]
        public string Product { get; set; }

        [Column("Created")]
        public DateTime Created { get; set; }

        [Column("Modified")]
        public DateTime Modified { get; set; }

    }
}
