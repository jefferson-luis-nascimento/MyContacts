using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContacts.Domain.Entities
{
    public class Person : BaseEntity
    {
        public Guid AddressId { get; set; }
        public virtual Address Address { get; set; }
    }
}
