using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyContacts.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContacts.Repository.Maps
{
    public class PersonMap : BaseEntityMap<Person>
    {
        public PersonMap() 
            : base("person") 
        {

        }

        public override void Configure(EntityTypeBuilder<Person> builder)
        {
            base.Configure(builder);

            builder.HasOne(person => person.Address)
                .WithMany(address => address.Persons)
                .HasForeignKey(person => person.AddressId);
        }
    }
}
