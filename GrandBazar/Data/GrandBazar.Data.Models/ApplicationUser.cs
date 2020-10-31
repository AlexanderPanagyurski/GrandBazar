// ReSharper disable VirtualMemberCallInConstructor
namespace GrandBazar.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using GrandBazar.Data.Common.Models;
    using GrandBazar.Data.Models.Enums;
    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
        }

        [Required]
        [MaxLength(AttributesConstraints.UserNameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.UserNameMaxLength)]
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public Gender Gender { get; set; }

        public string ImageUrl { get; set; }

        public string CoverImageUrl { get; set; }

        public string AboutMe { get; set; }

        public bool IsBlocked { get; set; }

        public string TwitterUrl { get; set; }

        public string FacebookUrl { get; set; }

        public string InstagramUrl { get; set; }

        [Required]
        [ForeignKey(nameof(Country))]
        public string CountryId { get; set; }

        public virtual Country Country { get; set; }

        [Required]
        [ForeignKey(nameof(City))]
        public string CityId { get; set; }

        public virtual City City { get; set; }

        public virtual ICollection<ChatMessage> ChatMessages { get; set; } = new HashSet<ChatMessage>();

        public virtual ICollection<ProductComment> ProductComments { get; set; } = new HashSet<ProductComment>();

        public virtual ICollection<ProductReview> ProductReviews { get; set; } = new HashSet<ProductReview>();

        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; } = new HashSet<ShoppingCart>();

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
    }
}
