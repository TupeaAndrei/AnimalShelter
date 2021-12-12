using AnimalShelter.DAL.Entities;
using AnimalShelter.DAL.Interfaces;
using AnimalShelter.DAL.Migrations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.DAL.Repositories
{
    public class AnimalShelterRepository<T> : IAnimalShelterRepository<T> where T : class,IEntity
    {
        private readonly ApplicationDbContext _context;
        
        public AnimalShelterRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<T> Add(T entity)
        {
            if (entity != null)
            {
                _context.Set<T>().Add(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            throw new DbUpdateException();
        }

        public async Task<T> Delete(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity == null)
            {
                return null;
            }
            try
            {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch(DbUpdateException)
            {
                throw;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public async Task<T> FindById(int id)
        {
            if (id <=0)
            {
                throw new ArgumentException(nameof(id));
            }
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

     

        public async Task<T> Update(T entity)
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
            catch(DbUpdateException)
            {
                throw;
            }
        }
    }
}
