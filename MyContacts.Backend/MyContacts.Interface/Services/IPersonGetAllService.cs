using MyContacts.Domain.Entities;

namespace MyContacts.Interface.Services
{
    public interface IPersonGetAllService<TEntity, TOut> : IBaseService<TEntity, TOut> where TEntity : Person
    {

    }
}
