using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductTag : Auditable<Guid>
    {
        public string Name { get; set; } = default!;
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = default!;
    }
}
