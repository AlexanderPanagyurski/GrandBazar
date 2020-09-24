using GrandBazar.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GrandBazar.Models
{
    public class ProductReview
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Range(AttributesConstraints.ProductReviewMinRate,AttributesConstraints.ProductReviewMaxRate)]
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

        [ForeignKey(nameof(Product))]
        public string ProductId { get; set; }
        public virtual Product Product { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public virtual User User { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

    }
}
