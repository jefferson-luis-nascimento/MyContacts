using MyContacts.Domain.Entities;
using System.Threading.Tasks;

namespace MyContacts.Interface.Services
{
    public interface IBaseService<TEntity, TOut> where TEntity : BaseEntity
    {
        Task<TOut> Execute();
    }
}
