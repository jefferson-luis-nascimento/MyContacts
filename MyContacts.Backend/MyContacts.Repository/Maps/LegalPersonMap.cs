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
    public class LegalPersonMap : BaseEntityMap<LegalPerson>
    {
        public LegalPersonMap() 
            : base("legal_person") 
        {

        }

        public override void Configure(EntityTypeBuilder<LegalPerson> builder)
        {
            base.Configure(builder);

            builder.Property(person => person.CompanyName.FullName).HasColumnName("company_name").HasMaxLength(200).IsRequired();
            builder.Property(person => person.TradeName.FullName).HasColumnName("trade_name").HasMaxLength(200).IsRequired();
            builder.Property(person => person.Cnpj.Number).HasColumnName("cnpj").HasMaxLength(18).IsRequired();
        }
    }
}
