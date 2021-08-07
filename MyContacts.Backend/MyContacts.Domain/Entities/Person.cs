using System;

namespace MyContacts.Domain.Entities
{
    public class Person : BaseEntity
    {
        public Guid AddressId { get; set; }
        public virtual Address Address { get; set; }
    }
}
