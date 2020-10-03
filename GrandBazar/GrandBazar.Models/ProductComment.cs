using GrandBazar.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GrandBazar.Models
{
    public class ProductComment
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(AttributesConstraints.ProductCommentUserFullNameMaxLength)]
        public string UserFullName { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.EmailMaxLength)]
        public string Email { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.ContentMaxLength)]
        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public virtual User User { get; set; }

        [Required]
        [ForeignKey(nameof(Product))]
        public string ProductId { get; set; }
        public virtual Product Product { get; set; }

        [ForeignKey(nameof(ProductComment))]
        public string ParentCommentId { get; set; }
        public virtual ProductComment ParentComment { get; set; }

        public virtual ICollection<ProductComment> CommentReplies { get; set; } = new HashSet<ProductComment>();
    }
}
