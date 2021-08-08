using MyContacts.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyContacts.Interface.Services
{
    public interface IPersonService<TPerson> where TPerson : Person
    {
        Task<TPerson> GetById(Guid id);
        Task<IEnumerable<TPerson>> GetAll();
        Task<TPerson> Create(TPerson person);
        Task<TPerson> Update(TPerson person);
        Task Delete(Guid id);
    }
}
