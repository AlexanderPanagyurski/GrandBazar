using GrandBazar.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GrandBazar.Models
{
    public class ProductImage
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [MaxLength(AttributesConstraints.ProductImageNameMaxLength)]
        public string Name { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [ForeignKey(nameof(Product))]
        public string ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
