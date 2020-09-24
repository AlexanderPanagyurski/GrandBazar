using GrandBazar.Common;
using GrandBazar.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GrandBazar.Models
{
    public class User
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(AttributesConstraints.UserNameMaxLength)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.UserNameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.UserNameMaxLength)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.EmailMaxLength)]
        public string Email { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime RegidteredOn { get; set; }

        public GenderType Gender { get; set; }

        public string ImageUrl { get; set; }

        public string CoverImageUrl { get; set; }

        public string AboutMe { get; set; }

        public bool IsBlocked { get; set; }

        public string TwitterUrl { get; set; }

        public string FacebookUrl { get; set; }

        public string InstagramUrl { get; set; }

        [ForeignKey(nameof(Country))]
        public string CountryId { get; set; }
        public virtual Country Country { get; set; }

        [ForeignKey(nameof(City))]
        public string CityId { get; set; }
        public virtual City City { get; set; }

        [ForeignKey(nameof(ShoppingCart))]
        public string ShoppingCartId { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }

        public virtual ICollection<ChatMessage> ChatMessages { get; set; } = new HashSet<ChatMessage>();

        public virtual ICollection<ProductComment> ProductComments { get; set; } = new HashSet<ProductComment>();

        public virtual ICollection<ProductReview> ProductReviews { get; set; } = new HashSet<ProductReview>();
    }
}
