﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GrandBazar.Services.Models
{
    public class ProductCreateServiceModel
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool IsArchived { get; set; }

        public DateTime? ArchivedOn { get; set; }

        public int AvailableQuantity { get; set; }

        public string ProductCategoryId { get; set; }
    }
}
