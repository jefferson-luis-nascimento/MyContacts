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
    public class BaseEntityMap<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        private readonly string _tableName;

        public BaseEntityMap()
        {
            _tableName = string.Empty;
        }

        public BaseEntityMap(string tableName)
        {
            _tableName = tableName;
        }

        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            //if(!string.IsNullOrWhiteSpace(_tableName))
            //{
            //    builder.ToTable(_tableName);
            //}

            //builder.Property(entity => entity.Id).HasColumnName("id");
            //builder.Property(entity => entity.CreatedIn).HasColumnName("created_in").IsRequired();

            //builder.HasKey(entity => entity.Id).IsClustered();
        }
    }
}
