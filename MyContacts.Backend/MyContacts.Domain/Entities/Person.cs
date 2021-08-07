using MyContacts.Domain.VOs;
using System;

namespace MyContacts.Domain.Entities
{
    public abstract class Person : BaseEntity
    {
        public Guid AddressId { get; set; }
        public Address Address { get; set; }

        public Person(Address address)
        {
            Address = address;
        }
    }
}
