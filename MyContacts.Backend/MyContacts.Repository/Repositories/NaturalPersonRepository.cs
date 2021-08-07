using Microsoft.EntityFrameworkCore;
using MyContacts.Domain.Entities;
using MyContacts.Interface.Repositories;
using MyContacts.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContacts.Repository.Repositories
{
    public class NaturalPersonRepository : INaturalPersonRepository
    {
        private readonly ApplicationDbContext _context;

        public NaturalPersonRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<NaturalPerson> GetById(Guid id)
        {
            return await _context.NaturalPersons.SingleOrDefaultAsync(entity => entity.Id == id);
        }

        public async Task<IEnumerable<NaturalPerson>> GetAll()
        {
            return await _context.NaturalPersons.ToListAsync();
        }

        public async Task<NaturalPerson> Create(NaturalPerson entity)
        {
            await _context.NaturalPersons.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<NaturalPerson> Update(NaturalPerson entity)
        {
            var entityToUpdate = await GetById(entity.Id);

            if (entityToUpdate != null)
            {
                _context.Entry(entityToUpdate).CurrentValues.SetValues(entity);

                await _context.SaveChangesAsync();
            }

            return entityToUpdate;
        }

        public async Task Delete(Guid id)
        {
            var entityToRemove = await GetById(id);

            if (entityToRemove != null)
            {
                _context.NaturalPersons.Remove(entityToRemove);

                await _context.SaveChangesAsync();
            }
        }
    }
}
