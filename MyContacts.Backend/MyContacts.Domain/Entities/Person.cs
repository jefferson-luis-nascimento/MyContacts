using MyContacts.Domain.VOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContacts.Domain.Entities
{
    public abstract class Person : BaseEntity
    {
        public Address Address { get; set; }
    }
}
