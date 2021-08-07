using System;

namespace MyContacts.Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedIn { get; set; }
        public DateTime? UpdatedIn { get; set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedIn = DateTime.Now;
        }
    }
}
