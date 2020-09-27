using GrandBazar.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GrandBazar.Models
{
    public class ZipCode
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [MaxLength(AttributesConstraints.OrderZipCodeMaxLength)]
        public string Code { get; set; }

        [MaxLength(AttributesConstraints.CityNameMaxLength)]
        public string City { get; set; }

        public virtual ICollection<User> Users { get; set; } = new HashSet<User>();
    }
}
