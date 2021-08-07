using MyContacts.Domain.Entities;
using MyContacts.Interface.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContacts.Service.Interfaces
{
   public interface IBaseService<TEntity, TOut> where TEntity : BaseEntity
    {
        Task<TOut> Execute();
    }
}
