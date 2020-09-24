using GrandBazar.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GrandBazar.Models
{
    public class City
    {
        [Required]
        public string CityId { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(AttributesConstraints.CityNameMaxLength)]
        public string Name { get; set; }

        [ForeignKey(nameof(Country))]
        public string CountryId { get; set; }
        public virtual Country Country { get; set; }

        public virtual ICollection<User> Users { get; set; } = new HashSet<User>();
    }
}
