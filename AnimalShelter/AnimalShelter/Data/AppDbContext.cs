using AnimalShelter.Authentification;
using AnimalShelter.DAL.Migrations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelter.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser,IdentityRole,string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {

        }
    }
}
