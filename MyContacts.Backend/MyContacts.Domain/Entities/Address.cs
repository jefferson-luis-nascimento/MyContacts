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
        public virtual List<LegalPerson> LegalPersons { get; set; }
        public virtual List<NaturalPerson> NaturalPersons { get; set; }

        public Address()
        {

        }

        public Address(string zipCode, string country, string state, string city, string addressLine1, string addressLine2)
        {
            ZipCode = zipCode;
            Country = country;
            State = state;
            City = city;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
        }
    }
}
