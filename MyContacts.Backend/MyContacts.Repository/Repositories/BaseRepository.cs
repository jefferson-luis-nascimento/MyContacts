using Microsoft.EntityFrameworkCore;
using MyContacts.Domain.Entities;
using MyContacts.Interface.Repositories;
using MyContacts.Repository.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyContacts.Repository.Repositories
{
    public abstract class BaseRepository<TEntity> //: IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        //protected readonly ApplicationDbContext Context;

        //private DbSet<TEntity> _dataSet;

        //public BaseRepository(ApplicationDbContext context)
        //{
        //    Context = context;
        //    _dataSet = Context.Set<TEntity>();
        //}

        //public async Task<TEntity> GetById(Guid id)
        //{
        //    return await _dataSet.SingleOrDefaultAsync(entity => entity.Id == id);
        //}

        //public async Task<IEnumerable<TEntity>> GetAll()
        //{
        //    return await _dataSet.ToListAsync();
        //}

        //public async Task<TEntity> Create(TEntity entity)
        //{
        //    await _dataSet.AddAsync(entity);
        //    await Context.SaveChangesAsync();

        //    return entity;
        //}

        //public async Task<TEntity> Update(TEntity entity)
        //{
        //    var entityToUpdate = await GetById(entity.Id);

        //    if(entityToUpdate != null)
        //    {
        //        Context.Entry(entityToUpdate).CurrentValues.SetValues(entity);

        //        await Context.SaveChangesAsync();
        //    }
            
        //    return entityToUpdate;
        //}

        //public async Task Delete(Guid id)
        //{
        //    var entityToRemove = await GetById(id);

        //    if (entityToRemove != null)
        //    {
        //        _dataSet.Remove(entityToRemove);

        //        await Context.SaveChangesAsync();
        //    }
        //}
    }
}
