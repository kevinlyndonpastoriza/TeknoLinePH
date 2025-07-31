using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Category : Audtiable<Guid>
    {
        public string Name { get; set; } = default!;
        public string Slug { get; set; } = default!;
        public List<Product> Products { get; set; } = new();
    }
}
