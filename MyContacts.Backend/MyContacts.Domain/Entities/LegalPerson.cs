using MyContacts.Domain.VOs;

namespace MyContacts.Domain.Entities
{
    public class LegalPerson : Person
    {
        public Name CompanyName { get; set; }
        public Name TradeName { get; set; }
        public Cnpj Cnpj { get; set; }

        public LegalPerson(Name companyName, Name tradeName, Cnpj cnpj, Address address)
            : base(address)
        {
            CompanyName = companyName;
            TradeName = tradeName;
            Cnpj = cnpj;
        }
    }
}
