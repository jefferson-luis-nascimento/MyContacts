using MyContacts.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyContacts.Interface.Services
{
    public interface INaturalPersonService
    {
        Task<IEnumerable<NaturalPerson>> GetAll();
    }
}
