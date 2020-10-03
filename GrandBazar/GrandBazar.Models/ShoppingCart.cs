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
        public string UserId { get; set; }
        public virtual User User { get; set; }

        public string ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
