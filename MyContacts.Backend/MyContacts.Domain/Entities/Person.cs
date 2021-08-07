using MyContacts.Domain.VOs;

namespace MyContacts.Domain.Entities
{
    public abstract class Person : BaseEntity
    {
        public Address Address { get; set; }

        public Person(Address address)
        {
            Address = address;
        }
    }
}
