using GrandBazar.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GrandBazar.Models
{
    public class Country
    {
        [Required]
        public string CountryId { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(AttributesConstraints.CountryNameMaxLength)]
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; } = new HashSet<City>();
        
        public virtual ICollection<User> Users { get; set; } = new HashSet<User>();
    }
}
