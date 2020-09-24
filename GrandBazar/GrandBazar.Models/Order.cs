using GrandBazar.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GrandBazar.Models
{
    public class Order
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(AttributesConstraints.OrderFirstNameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.OrderLastNameMaxLength)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.EmailMaxLength)]
        public string Email { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.OrderPhoneMaxLength)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.EmailMaxLength)]
        public string Address { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.OrderCountryMaxLength)]
        public string Country { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.OrderCityMaxLength)]
        public string City { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.OrderZipCodeMaxLength)]
        public string ZipCode { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.OrderAdditionalInformationMaxLength)]
        public string AdditionalInformation { get; set; }

        public DateTime? CaleledOn { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? FinishedOn { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new HashSet<OrderProduct>();
    }
}
