using MyContacts.Domain.VOs;
using System;

namespace MyContacts.Domain.Entities
{
    public class LegalPerson : Person
    {
        public string CompanyName { get; set; }
        public string TradeName { get; set; }
        public string Cnpj { get; set; }

        public LegalPerson()
        {

        }
    }
}
