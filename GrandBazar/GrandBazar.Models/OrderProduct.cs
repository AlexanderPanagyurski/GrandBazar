using System;
using System.Collections.Generic;
using System.Text;

namespace GrandBazar.Models
{
    public class OrderProduct
    {
        public string ProductId { get; set; } = Guid.NewGuid().ToString();
        public virtual Product Product { get; set; }

        public string OrderId { get; set; } = Guid.NewGuid().ToString();
        public virtual Order Order { get; set; }
    }
}
