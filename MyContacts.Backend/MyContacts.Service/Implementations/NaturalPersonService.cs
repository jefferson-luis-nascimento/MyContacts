using MyContacts.Domain.Entities;
using MyContacts.Interface.Repositories;
using MyContacts.Interface.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyContacts.Service.Implementations
{
    public class NaturalPersonService : INaturalPersonService
    {
        private INaturalPersonRepository _repository;

        public NaturalPersonService(INaturalPersonRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<NaturalPerson>> GetAll() => await _repository.GetAll();
    }
}
