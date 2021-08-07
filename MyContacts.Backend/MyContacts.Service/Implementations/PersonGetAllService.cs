using MyContacts.Domain.Entities;
using MyContacts.Interface.Repositories;
using MyContacts.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContacts.Service.Implementations
{
    public class PersonGetAllService<TEntity> : IPersonGetAllService<TEntity, IEnumerable<TEntity>> where TEntity : Person
    {
        private IBaseRepository<TEntity> _repository;

        public PersonGetAllService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<TEntity>> Execute() => await _repository.GetAll();
    }
}
