using AnimalShelter.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.DAL.Migrations
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<AdoptionPaper> AdoptionPapers { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Cage> Cages { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<MedicalCare> Interventions { get; set; }
        public DbSet<MedicalJournal> MedicalJournals { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<Donation> Donations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {  
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Animal>().HasData(
                new Animal
                {
                    AnimalID = 1,
                    Name = "Alfie",
                    Age = 3,
                    Race = "German Shepherd",
                    RegistrationDate = new DateTime(2019, 5, 3),
                    Type = "House dog",
                    OptionalDetails = "Good with everyone"
                },
                new Animal
                {
                    AnimalID = 2,
                    Name = "Darla",
                    OptionalDetails = "Good with everyone",
                    Age = 2,
                    Race = "Belgian Malinois",
                    RegistrationDate = new DateTime(2020, 10, 10),
                    Type = "Guard Dog"
                },
                new Animal
                {
                    AnimalID = 3,
                    Name = "Bruno",
                    OptionalDetails = "Good with everyone",
                    Age = 1,
                    Race = "Unknown",
                    RegistrationDate = new DateTime(2021, 2, 2),
                    Type = "House dog"
                },
                new Animal
                {
                    AnimalID = 4,
                    Name = "Brownie",
                    OptionalDetails = "Good with everyone",
                    Age = 1,
                    Race = "Bloodhound",
                    RegistrationDate = new DateTime(2021, 1, 1),
                    Type = "House dog"
                },
                new Animal
                {
                    AnimalID = 5,
                    Name = "Sparky",
                    OptionalDetails = "Good with everyone, oldest dog",
                    Age = 10,
                    Race = "unknown",
                    RegistrationDate = new DateTime(2018, 10, 10),
                    Type = "Guard dog"
                },
                new Animal
                {
                    AnimalID = 6,
                    Name = "Bella",
                    OptionalDetails = "Good with everyone",
                    Age = 2,
                    Race = "Unknown",
                    RegistrationDate = new DateTime(2019,5,6),
                    Type = "House dog"
                },
                new Animal
                {
                    AnimalID = 7,
                    Name = "Benji",
                    OptionalDetails = "Doesn't like cats",
                    Age = 6,
                    Race = "Boxer",
                    RegistrationDate = new DateTime(2019,10,11),
                    Type = "Guard Dog"
                },
                new Animal
                {
                    AnimalID = 8,
                    Name = "Bailey",
                    OptionalDetails = "Good with other dogs",
                    Race = "Unknown",
                    Age = 2,
                    RegistrationDate = new DateTime(2020,1,1),
                    Type = "House dog"
                },
                new Animal
                {
                    AnimalID = 9,
                    Name = "Lucky",
                    OptionalDetails = "Shy a little scared by other dogs",
                    Age = 2,
                    Race = "Unknown",
                    RegistrationDate = new DateTime(2021,3,5),
                    Type = "House dog"
                },
                new Animal
                {
                    AnimalID = 10,
                    Name = "Max",
                    OptionalDetails = "Good with people, bad with other animals",
                    Age = 3,
                    Race = "Rhodesian Ridgeback",
                    RegistrationDate = new DateTime(2020,10,1),
                    Type = "Guard Dog"
                },
                new Animal
                {
                    AnimalID = 11,
                    Name = "Kira",
                    OptionalDetails = "Good with everyone",
                    Age = 2,
                    Race ="Brittany",
                    RegistrationDate = new DateTime(2019,1,1),
                    Type = "House dog"
                },
                new Animal
                {
                    AnimalID = 12,
                    Name = "Koko",
                    OptionalDetails = "Good with everyone",
                    Age = 3,
                    Race = "Unknown",
                    RegistrationDate = new DateTime(2020,1,1),
                    Type = "House dog"
                },
                new Animal
                {
                    AnimalID = 13,
                    Name = "Maya",
                    OptionalDetails = "Good with other animals",
                    Age = 6,
                    Race = "American Curl",
                    RegistrationDate = new DateTime(2021,1,3),
                    Type = "House cat"
                },
                new Animal
                {
                    AnimalID = 14,
                    Name = "Milo",
                    OptionalDetails = "Good with everyone",
                    Age = 2,
                    Race = "Unknown",
                    RegistrationDate = new DateTime(2019,3,3),
                    Type = "Garden cat"
                },
                new Animal
                {
                    AnimalID = 15,
                    Name="Loki",
                    OptionalDetails = "Good with everyone but shy, The youngest pet in the shelter",
                    Age = 1,
                    Race = "Siberien",
                    RegistrationDate = new DateTime(2021,12,12),
                    Type = "House cat"
                },
                new Animal
                {
                    AnimalID = 16,
                    Name = "Misty",
                    OptionalDetails = "Bad wiith other animals",
                    Age = 3,
                    Race = "Bobtail des Kouriles",
                    RegistrationDate = new DateTime(2020,1,3),
                    Type = "House cat"
                },
                new Animal
                {
                    AnimalID = 17,
                    Name = "Oreo",
                    OptionalDetails = "Good with everyone, but a little scared",
                    Age = 4,
                    Race ="Unknown",
                    RegistrationDate = new DateTime(2019,10,11),
                    Type = "Garden cat"
                },
                new Animal
                {
                    AnimalID = 18,
                    Name = "Blanca & Blanco",
                    OptionalDetails = "Scared of dogs, Din't want to be separated",
                    Race = "American Curl",
                    Age = 4,
                    RegistrationDate = new DateTime(2018,10,1),
                    Type = "House cats"
                },
                new Animal
                {
                    AnimalID = 19,
                    Name = "Sammy & Ivi",
                    OptionalDetails = "Don't want to be separated, very scared much love needed",
                    Age = 2,
                    Race = "Unknown",
                    RegistrationDate = new DateTime(2020,2,1),
                    Type = "House cats"
                },
                new Animal
                {
                    AnimalID = 20,
                    Name = "Cara",
                    OptionalDetails = "Good with everyone",
                    Age = 4,
                    Race = "Bengal",
                    RegistrationDate = new DateTime(2019,10,11),
                    Type = "Garden cat"
                },
                new Animal
                {
                    AnimalID = 21,
                    Name = "Nala",
                    OptionalDetails = "Good with everyone, very playful",
                    Age = 1,
                    Race = "Unknown",
                    RegistrationDate = new DateTime(2021,10,9),
                    Type = "house cat"
                }
                );
            modelBuilder.Entity<MedicalJournal>().HasData(
                new MedicalJournal
                {
                    JournalID = 1,
                    AnimalID = 1,
                    Illness = "Diabetes",
                    Date = DateTime.Now,
                    Treatment = new List<string> { "remove meat from diet for 3 days" },
                    Symptoms = new List<string> { "fever","Insomnya"}
                }) ;
            modelBuilder.Entity<EmployeeType>().HasData(
                new EmployeeType
                {
                    TypeID = 1,
                    AnimalID = 2,
                    Role = "Cleaner",
                    Salary = 2545,
                    Responsibilities = new List<string> { "cleaning cages", "keeping enviroment clear" }
                }) ;
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeID = 1,
                    Age = 32,
                    Name = "Andrei",
                    Address = "Libertatii",
                    PhoneNumber = "0745568755",
                    TypeID = 1
                });
            modelBuilder.Entity<Cage>().HasData(
                new Cage
                {
                    CageID = 1,
                    AnimalID = 1,
                    Dimension = 20,
                    Label = "green"
                },
                new Cage
                {
                    CageID = 2,
                    AnimalID = 2,
                    Dimension = 20,
                    Label = "green"
                },
                new Cage
                {
                    CageID = 3,
                    AnimalID = 4,
                    Dimension = 20,
                    Label = "Yellow"
                },
                new Cage
                {
                    CageID = 4,
                    AnimalID = 3,
                    Dimension = 10,
                    Label = "Red"
                },
                new Cage
                {
                    CageID = 5,
                    AnimalID = 5,
                    Dimension = 14,
                    Label = "Green"
                },
                new Cage
                {
                    CageID = 6,
                    AnimalID = 7,
                    Dimension = 12,
                    Label = "Green"
                },
                new Cage
                {
                    CageID = 7,
                    AnimalID = 8,
                    Dimension = 13,
                    Label = "Green"
                },
                new Cage
                {
                    CageID = 8,
                    AnimalID = 6,
                    Dimension = 12,
                    Label = "Green"
                },
                new Cage
                {
                    CageID = 9,
                    AnimalID = 9,
                    Dimension = 10,
                    Label = "Yellow"
                },
                new Cage
                {
                    CageID = 10,
                    AnimalID = 10,
                    Dimension = 11,
                    Label = "Green"
                },
                new Cage
                {
                    CageID = 11,
                    AnimalID = 11,
                    Dimension = 20,
                    Label = "Yellow"
                },
                new Cage
                {
                    CageID = 12,
                    AnimalID = 12,
                    Dimension = 19,
                    Label = "green"
                },
                new Cage
                {
                    CageID = 13,
                    AnimalID = 13,
                    Dimension = 12,
                    Label = "green"
                },
                new Cage
                {
                    CageID = 14,
                    AnimalID = 14,
                    Dimension = 11,
                    Label = "red"
                },
                new Cage
                {
                    CageID = 15,
                    AnimalID = 15,
                    Dimension = 19,
                    Label = "green"
                },
                new Cage
                {
                    CageID = 16,
                    AnimalID = 16,
                    Dimension = 16,
                    Label = "yellow"
                },
                new Cage
                {
                    CageID = 17,
                    AnimalID = 17,
                    Dimension = 10,
                    Label = "green"
                },
                new Cage
                {
                    CageID = 18,
                    AnimalID = 18,
                    Dimension = 12,
                    Label = "green"
                },
                new Cage
                {
                    CageID = 19,
                    AnimalID = 19,
                    Dimension = 10,
                    Label = "red"
                });
        }
    }
        
}
