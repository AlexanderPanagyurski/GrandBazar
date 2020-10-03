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

        public string UserId { get; set; }

        //[DataType(DataType.Upload)]
        //public ICollection<IFormFile> Images { get; set; }

        public string ProductCategoryId { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? EditedOn { get; set; }

        public bool IsArchived { get; set; }

        public DateTime? ArchivedOn { get; set; }

        public string TownId { get; set; }

        public string Address { get; set; }

        public string Number { get; set; }

        public int AvailableQuantity { get; set; }

    }
}
