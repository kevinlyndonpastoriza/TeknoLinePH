﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Brand : Auditable<Guid>
    {
        public string Name { get; set; } = default!;
        public List<Product> Products { get; set; } = new();
    }
}
