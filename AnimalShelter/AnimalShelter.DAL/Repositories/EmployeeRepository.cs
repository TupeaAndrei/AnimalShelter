using AnimalShelter.DAL.Entities;
using AnimalShelter.DAL.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.DAL.Repositories
{
    public class EmployeeRepository : AnimalShelterRepository<Employee,ApplicationDbContext>
    {
        public EmployeeRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
