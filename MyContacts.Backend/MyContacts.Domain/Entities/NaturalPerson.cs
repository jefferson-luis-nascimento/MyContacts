using MyContacts.Domain.Enums;
using MyContacts.Domain.VOs;
using System;

namespace MyContacts.Domain.Entities
{
    public class NaturalPerson : Person
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }
    }
}
