using AnimalShelter.DAL.Interfaces;
using AnimalShelter.DAL.Migrations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.DAL.Repositories
{
    public abstract class AnimalShelterRepository<TEntity,TContext> : IAnimalShelterRepository<TEntity>
        where TEntity : class,IEntity
        where TContext : ApplicationDbContext
    {
        private readonly TContext _context;
        
        public AnimalShelterRepository(TContext context)
        {
            this._context = context;
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Add(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (DbUpdateException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<TEntity> Delete(int id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                return null;
            }
            try
            {
                _context.Set<TEntity>().Remove(entity);
                await _context.SaveChangesAsync();

                return entity;
            }
            catch (DbUpdateException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<TEntity> FindById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (DbUpdateException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
