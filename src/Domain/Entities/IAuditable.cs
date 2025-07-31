using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public interface IAuditable
    {
        DateTime CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? LastModifiedDate { get; set; }
        string LastModifiedBy { get; set; }
    }

    public interface IAuditable<T> : IAuditable
    {
        T Id { get; set; }
    }
}
