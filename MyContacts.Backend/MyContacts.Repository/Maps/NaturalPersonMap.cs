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
    public class NaturalPersonMap : BaseEntityMap<NaturalPerson>
    {
        public NaturalPersonMap() 
            : base("natural_person") 
        {

        }

        public override void Configure(EntityTypeBuilder<NaturalPerson> builder)
        {
            base.Configure(builder);

            builder.Property(person => person.Name.FullName).HasColumnName("name").HasMaxLength(200).IsRequired();
            builder.Property(person => person.CPF.Number).HasColumnName("cpf").HasMaxLength(14).IsRequired();
            builder.Property(person => person.Birthday).HasColumnName("birthday").IsRequired();
            builder.Property(person => person.Gender).HasColumnName("gender").IsRequired();
        }
    }
}
