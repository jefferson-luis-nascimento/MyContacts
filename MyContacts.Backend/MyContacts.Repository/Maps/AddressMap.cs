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
    public class AddressMap : BaseEntityMap<Address>
    {
        public AddressMap() 
            : base("legal_person") 
        {

        }

        public override void Configure(EntityTypeBuilder<Address> builder)
        {
            base.Configure(builder);

            builder.Property(address => address.AddressLine1).HasColumnName("address_line1").HasMaxLength(200).IsRequired();
            builder.Property(address => address.AddressLine2).HasColumnName("address_line2").HasMaxLength(200).IsRequired();
            builder.Property(address => address.City).HasColumnName("city").HasMaxLength(200).IsRequired();
            builder.Property(address => address.State).HasColumnName("state").HasMaxLength(2).IsRequired();
            builder.Property(address => address.Country).HasColumnName("country").HasMaxLength(200).IsRequired();
            builder.Property(address => address.ZipCode).HasColumnName("zip_code").HasMaxLength(20).IsRequired();

        }
    }
}
