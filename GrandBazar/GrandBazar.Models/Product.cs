using GrandBazar.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GrandBazar.Models
{
    public class Product
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(AttributesConstraints.ProductNameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.DescriptionMaxLength)]
        public string Description { get; set; }

        [Range(typeof(decimal),AttributesConstraints.PriceMinValue,AttributesConstraints.PriceMaxValue)]
        public decimal Price { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [ForeignKey(nameof(ProductCategory))]
        public string ProductCategoryId { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }

        [ForeignKey(nameof(ShoppingCart))]
        public string ShoppingCartId { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }

        public int AvailableQuantity { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new HashSet<OrderProduct>();

        public virtual ICollection<ProductComment> ProductComments { get; set; } = new HashSet<ProductComment>();

        public virtual ICollection<ProductReview> ProductReviews { get; set; } = new HashSet<ProductReview>();

        public virtual ICollection<ProductImage> ProductImages { get; set; } = new HashSet<ProductImage>();

    }
}
