using System.Collections.Generic;

namespace MyContacts.Domain.Entities
{
    public class Address : BaseEntity
    {
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public virtual List<Person> Persons { get; set; }
    }
}
