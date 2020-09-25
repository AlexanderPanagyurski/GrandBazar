using GrandBazar.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace GrandBazar.Models
{
    public class ShoppingCart
    {
        public string Id { get; set; } = new Guid().ToString();

        [Range(typeof(decimal),AttributesConstraints.PriceMinValue,AttributesConstraints.PriceMaxValue)]
        public decimal TotalPrice { get => this.Products.Sum(p => p.Price); }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
