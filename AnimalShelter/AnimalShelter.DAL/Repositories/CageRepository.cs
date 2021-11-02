using AnimalShelter.DAL.Entities;
using AnimalShelter.DAL.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.DAL.Repositories
{
    public class CageRepository : AnimalShelterRepository<Cage, ApplicationDbContext>
    {
        /// <summary>
        /// Empty constructor used to call, constructor from base abstract class,
        /// After this we can add more specific methods if they are needed
        /// </summary>
        /// <param name="context"></param>
        public CageRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
