using System;
using System.Collections.Generic;
using System.Text;

namespace GrandBazar.Services.Models
{
    public class ProductViewServiceModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public string ProductCategoryId { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ArchivedOn { get; set; }

        public bool IsArchived { get; set; }

        public bool IsPromoted { get; set; }

        public DateTime? PromotedOn { get; set; }

        public DateTime? PromotedUntil { get; set; }

        public int Views { get; set; }
    }
}
