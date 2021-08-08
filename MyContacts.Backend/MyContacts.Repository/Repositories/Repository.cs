using Microsoft.EntityFrameworkCore;
using MyContacts.Domain.Entities;
using MyContacts.Interface.Repositories;
using MyContacts.Repository.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyContacts.Repository.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly ApplicationDbContext _context;

        private DbSet<TEntity> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public async Task<TEntity> GetById(Guid id)
        {
            return await _dbSet.SingleOrDefaultAsync(entity => entity.Id == id);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> Create(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
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
                _dbSet.Remove(entityToRemove);

                await _context.SaveChangesAsync();
            }
        }
    }
}
