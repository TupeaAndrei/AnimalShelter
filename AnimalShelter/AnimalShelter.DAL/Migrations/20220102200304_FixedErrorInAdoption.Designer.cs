﻿// <auto-generated />
using System;
using AnimalShelter.DAL.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220102200304_FixedErrorInAdoption")]
    partial class FixedErrorInAdoption
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AnimalShelter.DAL.Entities.AdoptionPaper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdoptionReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adresss")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Allergy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnimalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("HouseType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PetCount")
                        .HasColumnType("int");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preparations")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Town")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VisiterID")
                        .HasColumnType("int");

                    b.Property<int?>("VisitorID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VisitorID");

                    b.ToTable("AdoptionPapers");
                });

            modelBuilder.Entity("AnimalShelter.DAL.Entities.Animal", b =>
                {
                    b.Property<int>("AnimalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionalDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Race")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnimalID");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalID = 1,
                            Age = 3,
                            Name = "Alfie",
                            OptionalDetails = "Good with everyone",
                            Race = "German Shepherd",
                            RegistrationDate = new DateTime(2019, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "House dog"
                        },
                        new
                        {
                            AnimalID = 2,
                            Age = 2,
                            Name = "Darla",
                            OptionalDetails = "Good with everyone",
                            Race = "Belgian Malinois",
                            RegistrationDate = new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Guard Dog"
                        },
                        new
                        {
                            AnimalID = 3,
                            Age = 1,
                            Name = "Bruno",
                            OptionalDetails = "Good with everyone",
                            Race = "Unknown",
                            RegistrationDate = new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "House dog"
                        },
                        new
                        {
                            AnimalID = 4,
                            Age = 1,
                            Name = "Brownie",
                            OptionalDetails = "Good with everyone",
                            Race = "Bloodhound",
                            RegistrationDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "House dog"
                        },
                        new
                        {
                            AnimalID = 5,
                            Age = 10,
                            Name = "Sparky",
                            OptionalDetails = "Good with everyone, oldest dog",
                            Race = "unknown",
                            RegistrationDate = new DateTime(2018, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Guard dog"
                        },
                        new
                        {
                            AnimalID = 6,
                            Age = 2,
                            Name = "Bella",
                            OptionalDetails = "Good with everyone",
                            Race = "Unknown",
                            RegistrationDate = new DateTime(2019, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "House dog"
                        },
                        new
                        {
                            AnimalID = 7,
                            Age = 6,
                            Name = "Benji",
                            OptionalDetails = "Doesn't like cats",
                            Race = "Boxer",
                            RegistrationDate = new DateTime(2019, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Guard Dog"
                        },
                        new
                        {
                            AnimalID = 8,
                            Age = 2,
                            Name = "Bailey",
                            OptionalDetails = "Good with other dogs",
                            Race = "Unknown",
                            RegistrationDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "House dog"
                        },
                        new
                        {
                            AnimalID = 9,
                            Age = 2,
                            Name = "Lucky",
                            OptionalDetails = "Shy a little scared by other dogs",
                            Race = "Unknown",
                            RegistrationDate = new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "House dog"
                        },
                        new
                        {
                            AnimalID = 10,
                            Age = 3,
                            Name = "Max",
                            OptionalDetails = "Good with people, bad with other animals",
                            Race = "Rhodesian Ridgeback",
                            RegistrationDate = new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Guard Dog"
                        },
                        new
                        {
                            AnimalID = 11,
                            Age = 2,
                            Name = "Kira",
                            OptionalDetails = "Good with everyone",
                            Race = "Brittany",
                            RegistrationDate = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "House dog"
                        },
                        new
                        {
                            AnimalID = 12,
                            Age = 3,
                            Name = "Koko",
                            OptionalDetails = "Good with everyone",
                            Race = "Unknown",
                            RegistrationDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "House dog"
                        },
                        new
                        {
                            AnimalID = 13,
                            Age = 6,
                            Name = "Maya",
                            OptionalDetails = "Good with other animals",
                            Race = "American Curl",
                            RegistrationDate = new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "House cat"
                        },
                        new
                        {
                            AnimalID = 14,
                            Age = 2,
                            Name = "Milo",
                            OptionalDetails = "Good with everyone",
                            Race = "Unknown",
                            RegistrationDate = new DateTime(2019, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Garden cat"
                        },
                        new
                        {
                            AnimalID = 15,
                            Age = 1,
                            Name = "Loki",
                            OptionalDetails = "Good with everyone but shy, The youngest pet in the shelter",
                            Race = "Siberien",
                            RegistrationDate = new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "House cat"
                        },
                        new
                        {
                            AnimalID = 16,
                            Age = 3,
                            Name = "Misty",
                            OptionalDetails = "Bad wiith other animals",
                            Race = "Bobtail des Kouriles",
                            RegistrationDate = new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "House cat"
                        },
                        new
                        {
                            AnimalID = 17,
                            Age = 4,
                            Name = "Oreo",
                            OptionalDetails = "Good with everyone, but a little scared",
                            Race = "Unknown",
                            RegistrationDate = new DateTime(2019, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Garden cat"
                        },
                        new
                        {
                            AnimalID = 18,
                            Age = 4,
                            Name = "Blanca & Blanco",
                            OptionalDetails = "Scared of dogs, Din't want to be separated",
                            Race = "American Curl",
                            RegistrationDate = new DateTime(2018, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "House cats"
                        },
                        new
                        {
                            AnimalID = 19,
                            Age = 2,
                            Name = "Sammy & Ivi",
                            OptionalDetails = "Don't want to be separated, very scared much love needed",
                            Race = "Unknown",
                            RegistrationDate = new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "House cats"
                        },
                        new
                        {
                            AnimalID = 20,
                            Age = 4,
                            Name = "Cara",
                            OptionalDetails = "Good with everyone",
                            Race = "Bengal",
                            RegistrationDate = new DateTime(2019, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Garden cat"
                        },
                        new
                        {
                            AnimalID = 21,
                            Age = 1,
                            Name = "Nala",
                            OptionalDetails = "Good with everyone, very playful",
                            Race = "Unknown",
                            RegistrationDate = new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "house cat"
                        });
                });

            modelBuilder.Entity("AnimalShelter.DAL.Entities.Cage", b =>
                {
                    b.Property<int>("CageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnimalID")
                        .HasColumnType("int");

                    b.Property<double>("Dimension")
                        .HasColumnType("float");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CageID");

                    b.HasIndex("AnimalID");

                    b.ToTable("Cages");

                    b.HasData(
                        new
                        {
                            CageID = 1,
                            AnimalID = 1,
                            Dimension = 20.0,
                            Label = "green"
                        },
                        new
                        {
                            CageID = 2,
                            AnimalID = 2,
                            Dimension = 20.0,
                            Label = "green"
                        },
                        new
                        {
                            CageID = 3,
                            AnimalID = 4,
                            Dimension = 20.0,
                            Label = "Yellow"
                        },
                        new
                        {
                            CageID = 4,
                            AnimalID = 3,
                            Dimension = 10.0,
                            Label = "Red"
                        },
                        new
                        {
                            CageID = 5,
                            AnimalID = 5,
                            Dimension = 14.0,
                            Label = "Green"
                        },
                        new
                        {
                            CageID = 6,
                            AnimalID = 7,
                            Dimension = 12.0,
                            Label = "Green"
                        },
                        new
                        {
                            CageID = 7,
                            AnimalID = 8,
                            Dimension = 13.0,
                            Label = "Green"
                        },
                        new
                        {
                            CageID = 8,
                            AnimalID = 6,
                            Dimension = 12.0,
                            Label = "Green"
                        },
                        new
                        {
                            CageID = 9,
                            AnimalID = 9,
                            Dimension = 10.0,
                            Label = "Yellow"
                        },
                        new
                        {
                            CageID = 10,
                            AnimalID = 10,
                            Dimension = 11.0,
                            Label = "Green"
                        },
                        new
                        {
                            CageID = 11,
                            AnimalID = 11,
                            Dimension = 20.0,
                            Label = "Yellow"
                        },
                        new
                        {
                            CageID = 12,
                            AnimalID = 12,
                            Dimension = 19.0,
                            Label = "green"
                        },
                        new
                        {
                            CageID = 13,
                            AnimalID = 13,
                            Dimension = 12.0,
                            Label = "green"
                        },
                        new
                        {
                            CageID = 14,
                            AnimalID = 14,
                            Dimension = 11.0,
                            Label = "red"
                        },
                        new
                        {
                            CageID = 15,
                            AnimalID = 15,
                            Dimension = 19.0,
                            Label = "green"
                        },
                        new
                        {
                            CageID = 16,
                            AnimalID = 16,
                            Dimension = 16.0,
                            Label = "yellow"
                        },
                        new
                        {
                            CageID = 17,
                            AnimalID = 17,
                            Dimension = 10.0,
                            Label = "green"
                        },
                        new
                        {
                            CageID = 18,
                            AnimalID = 18,
                            Dimension = 12.0,
                            Label = "green"
                        },
                        new
                        {
                            CageID = 19,
                            AnimalID = 19,
                            Dimension = 10.0,
                            Label = "red"
                        });
                });

            modelBuilder.Entity("AnimalShelter.DAL.Entities.Donation", b =>
                {
                    b.Property<int>("DonationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Sum")
                        .HasColumnType("float");

                    b.Property<int>("VisitorID")
                        .HasColumnType("int");

                    b.HasKey("DonationID");

                    b.HasIndex("VisitorID");

                    b.ToTable("Donations");
                });

            modelBuilder.Entity("AnimalShelter.DAL.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeID")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID");

                    b.HasIndex("TypeID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeID = 1,
                            Address = "Libertatii",
                            Age = 32,
                            Name = "Andrei",
                            PhoneNumber = "0745568755",
                            TypeID = 1
                        });
                });

            modelBuilder.Entity("AnimalShelter.DAL.Entities.EmployeeType", b =>
                {
                    b.Property<int>("TypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnimalID")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("TypeID");

                    b.HasIndex("AnimalID");

                    b.ToTable("EmployeeTypes");

                    b.HasData(
                        new
                        {
                            TypeID = 1,
                            AnimalID = 2,
                            Role = "Cleaner",
                            Salary = 2545.0
                        });
                });

            modelBuilder.Entity("AnimalShelter.DAL.Entities.MedicalCare", b =>
                {
                    b.Property<int>("InterventionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnimalID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("Service")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InterventionID");

                    b.HasIndex("AnimalID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Interventions");
                });

            modelBuilder.Entity("AnimalShelter.DAL.Entities.MedicalJournal", b =>
                {
                    b.Property<int>("JournalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnimalID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Illness")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionalDetails")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JournalID");

                    b.HasIndex("AnimalID");

                    b.ToTable("MedicalJournals");

                    b.HasData(
                        new
                        {
                            JournalID = 1,
                            AnimalID = 1,
                            Date = new DateTime(2022, 1, 2, 22, 3, 4, 499, DateTimeKind.Local).AddTicks(6645),
                            Illness = "Diabetes"
                        });
                });

            modelBuilder.Entity("AnimalShelter.DAL.Entities.Visitor", b =>
                {
                    b.Property<int>("VisitorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VisitorID");

                    b.ToTable("Visitors");
                });

            modelBuilder.Entity("AnimalShelter.DAL.Entities.AdoptionPaper", b =>
                {
                    b.HasOne("AnimalShelter.DAL.Entities.Visitor", "Visitor")
                        .WithMany()
                        .HasForeignKey("VisitorID");

                    b.Navigation("Visitor");
                });

            modelBuilder.Entity("AnimalShelter.DAL.Entities.Cage", b =>
                {
                    b.HasOne("AnimalShelter.DAL.Entities.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");
                });

            modelBuilder.Entity("AnimalShelter.DAL.Entities.Donation", b =>
                {
                    b.HasOne("AnimalShelter.DAL.Entities.Visitor", "Visitor")
                        .WithMany()
                        .HasForeignKey("VisitorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Visitor");
                });

            modelBuilder.Entity("AnimalShelter.DAL.Entities.Employee", b =>
                {
                    b.HasOne("AnimalShelter.DAL.Entities.EmployeeType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("AnimalShelter.DAL.Entities.EmployeeType", b =>
                {
                    b.HasOne("AnimalShelter.DAL.Entities.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");
                });

            modelBuilder.Entity("AnimalShelter.DAL.Entities.MedicalCare", b =>
                {
                    b.HasOne("AnimalShelter.DAL.Entities.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AnimalShelter.DAL.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID");

                    b.Navigation("Animal");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("AnimalShelter.DAL.Entities.MedicalJournal", b =>
                {
                    b.HasOne("AnimalShelter.DAL.Entities.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");
                });
#pragma warning restore 612, 618
        }
    }
}
