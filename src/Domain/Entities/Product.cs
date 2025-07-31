using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product : Audtiable<Guid>
    {
        public string Name { get; set; } = default!;
        public string Slug { get; set; } = default!;
        public string? ShortDescription { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }
        public string Currency { get; set; } = "USD";
        public string? SKU { get; set; }
        public string? Barcode { get; set; }
        public int StockQuantity { get; set; }
        public bool IsInStock { get; set; }
        public bool IsActive { get; set; }
        public bool IsFeatured { get; set; }

        public Guid? BrandId { get; set; }
        public Brand? Brand { get; set; }

        public List<ProductImage> ProductImages { get; set; } = new();
        public List<Category> Categories { get; set; } = new();
        public List<ProductTag> Tags { get; set; } = new();
    }
}
