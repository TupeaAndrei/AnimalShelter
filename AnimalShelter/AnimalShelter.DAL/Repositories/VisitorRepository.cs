using AnimalShelter.DAL.Entities;
using AnimalShelter.DAL.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.DAL.Repositories
{
    public class VisitorRepository : AnimalShelterRepository<Visitor,ApplicationDbContext>
    {
        public VisitorRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
