using MyContacts.Domain.Enums;
using MyContacts.Domain.VOs;

namespace MyContacts.Domain.Entities
{
    public class NaturalPerson : Person
    {
        public Name Name { get; private set; }
        public Cpf CPF { get; private set; }
        public Birthday Birthday { get; private set; }
        public Gender Gender { get; private set; }

        public NaturalPerson(Name name, Cpf cpf, Birthday birthday, Gender gender, Address address)
            : base(address)
        {
            Name = name;
            CPF = cpf;
            Birthday = birthday;
            Gender = gender;
        }
    }
}
