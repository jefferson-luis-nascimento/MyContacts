using MyContacts.Domain.Entities;
using MyContacts.Interface.Repositories;
using MyContacts.Interface.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyContacts.Service.Implementations
{
    public class NaturalPersonService : IPersonService<NaturalPerson>
    {
        private IRepository<NaturalPerson> _repository;

        public NaturalPersonService(IRepository<NaturalPerson> repository)
        {
            _repository = repository;
        }

        public async Task<NaturalPerson> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public async Task<IEnumerable<NaturalPerson>> GetAll() => await _repository.GetAll();

        public async Task<NaturalPerson> Create(NaturalPerson person)
        {
            return await _repository.Create(person);
        }

        public async Task<NaturalPerson> Update(NaturalPerson person)
        {
            return await _repository.Update(person);
        }

        public async Task Delete(Guid id)
        {
            await _repository.Delete(id);
        }  
    }
}
