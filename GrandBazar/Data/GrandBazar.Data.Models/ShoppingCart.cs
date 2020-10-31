using System;
using System.Collections.Generic;
using System.Text;

namespace GrandBazar.Data.Models
{
    public class ShoppingCart
    {
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
