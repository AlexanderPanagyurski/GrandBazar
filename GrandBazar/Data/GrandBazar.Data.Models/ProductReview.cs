using GrandBazar.Data.Common.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrandBazar.Data.Models
{
    public class ProductReview
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Range(AttributesConstraints.ProductReviewMinRate, AttributesConstraints.ProductReviewMaxRate)]
        public double Rate { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.ProductReviewContentMaxLength)]
        public string Content { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.ProductReviewUserFullNameMaxLength)]
        public string UserFullName { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.ProductReviewPhoneMaxLength)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.ProductReviewEmailMaxLength)]
        public string Email { get; set; }

        [Required]
        [ForeignKey(nameof(Product))]
        public string ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Required]
        [ForeignKey(nameof(ApplicationUser))]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

    }
}