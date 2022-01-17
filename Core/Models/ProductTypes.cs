using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Models
{
    public class ProductTypes
    {
        [Key]
        [Column("ProductTypeId")]
        public int ProductTypeId { get; set; }

        [Column("ProductType")]
        [Required(ErrorMessage = "Product Type is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum length should not exceed 100 characters")]
        public string ProductType { get; set; }

        [Column("Created")]
        public DateTime Created { get; set; }

        [Column("Modified")]
        public DateTime Modified { get; set; }

    }
}
