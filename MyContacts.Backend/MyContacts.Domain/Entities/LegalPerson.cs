using MyContacts.Domain.VOs;
using System;

namespace MyContacts.Domain.Entities
{
    public class LegalPerson : BaseEntity
    {
        public string CompanyName { get; set; }
        public string TradeName { get; set; }
        public string Cnpj { get; set; }
        public Guid AddressId { get; set; }
        public virtual Address Address { get; set; }

        public LegalPerson()
        {

        }

        public LegalPerson(string companyName, string tradeName, string cnpj, Address address)
        {
            CompanyName = companyName;
            TradeName = tradeName;
            Cnpj = cnpj;
            Address = address;
        }
    }
}
