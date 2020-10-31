using GrandBazar.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GrandBazar.Data.Models
{
    public class Product
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(AttributesConstraints.ProductNameMaxLength)]
        public string Name { get; set; }


        [Range(typeof(decimal), AttributesConstraints.PriceMinValue, AttributesConstraints.PriceMaxValue)]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.DescriptionMaxLength)]
        public string Description { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool IsArchived { get; set; }

        public DateTime? ArchivedOn { get; set; }

        public bool IsPromoted { get; set; }

        public DateTime? PromotedOn { get; set; }

        public DateTime? PromotedUntil { get; set; }

        public int AvailableQuantity { get; set; }

        public int Views { get; set; }

        [Required]
        [ForeignKey(nameof(ProductCategory))]
        public string ProductCategoryId { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new HashSet<OrderProduct>();

        public virtual ICollection<ProductComment> ProductComments { get; set; } = new HashSet<ProductComment>();

        public virtual ICollection<ProductReview> ProductReviews { get; set; } = new HashSet<ProductReview>();

        public virtual ICollection<ProductImage> ProductImages { get; set; } = new HashSet<ProductImage>();

        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; } = new HashSet<ShoppingCart>();

    }
}
