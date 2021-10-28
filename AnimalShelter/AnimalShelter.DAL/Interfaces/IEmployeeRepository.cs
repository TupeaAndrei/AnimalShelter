using AnimalShelter.DAL.Entities;
using AnimalShelter.TL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.DAL.Interfaces
{
    public interface IEmployeeRepository
    {
        EmployeeDTO FindById(int id);
        List<EmployeeDTO> Employees { get; }
        void AddEmployee(EmployeeDTO employee);
        void RemoveEmployee(EmployeeDTO employee);
    }
}
