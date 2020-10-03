using System;
using System.Collections.Generic;
using System.Text;

namespace GrandBazar.Models
{
    public class WishList
    {
        public string UserId { get; set; }
        public virtual User User { get; set; }

        public string ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
