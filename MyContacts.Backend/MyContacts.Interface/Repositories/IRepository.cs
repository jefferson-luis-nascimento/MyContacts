using MyContacts.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyContacts.Interface.Repositories
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetById(Guid id);
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> Create(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task Delete(Guid id);        
    }
}
