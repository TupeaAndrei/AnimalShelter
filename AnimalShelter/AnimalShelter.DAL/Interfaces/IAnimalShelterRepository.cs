using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.DAL.Interfaces
{
    public interface IAnimalShelterRepository<T> where T : class,IEntity
    {
        Task<List<T>> GetAll();
        Task<T> FindById(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}
