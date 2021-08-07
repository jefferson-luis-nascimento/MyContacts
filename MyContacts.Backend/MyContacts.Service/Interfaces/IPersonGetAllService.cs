using MyContacts.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContacts.Service.Interfaces
{
    public interface IPersonGetAllService<TEntity, TOut> : IBaseService<TEntity, TOut> where TEntity : Person
    {

    }
}
