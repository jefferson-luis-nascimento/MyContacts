using MyContacts.Domain.Enums;
using MyContacts.Domain.VOs;
using System;

namespace MyContacts.Domain.Entities
{
    public class NaturalPerson : BaseEntity
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }
        public Guid AddressId { get; set; }
        public virtual Address Address { get; set; }

        public NaturalPerson()
        {

        }

        public NaturalPerson(string name, string cpf, DateTime birthday, Gender gender, Address address)
        {
            Name = name;
            CPF = cpf;
            Birthday = birthday;
            Gender = gender;
            Address = address;
        }
    }
}
