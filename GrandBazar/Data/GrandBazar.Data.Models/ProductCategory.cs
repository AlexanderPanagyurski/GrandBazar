using GrandBazar.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GrandBazar.Data.Models
{
    public class ProductCategory
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(AttributesConstraints.ProductCategoryTitleMaxLength)]
        public string Title { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.ProductCategoryDescMaxLength)]
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}