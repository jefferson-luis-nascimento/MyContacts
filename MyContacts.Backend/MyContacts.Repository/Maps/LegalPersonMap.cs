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
    public class LegalPersonMap :BaseEntityMap<LegalPerson>
    {
        public LegalPersonMap() 
            : base("legal_person") 
        {

        }

        //public override void Configure(EntityTypeBuilder<LegalPerson> builder)
        //{
        //    base.Configure(builder);

        //    builder.Property(person => person.CompanyName).HasColumnName("company_name").HasMaxLength(200).IsRequired();
        //    builder.Property(person => person.TradeName).HasColumnName("trade_name").HasMaxLength(200).IsRequired();
        //    builder.Property(person => person.Cnpj).HasColumnName("cnpj").HasMaxLength(18).IsRequired();
        //    builder.Property(person => person.AddressId).HasColumnName("address_id").IsRequired();
        //    builder.HasOne(person => person.Address).WithMany(address => address.LegalPersons).HasForeignKey(person => person.AddressId);
        //}
    }
}
