using AnimalShelter.DAL.Entities;
using AnimalShelter.TL.DTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelter.AutoMapperConfig
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AdoptionPaper, AdoptionPaperDTO>().ReverseMap();
            CreateMap<Animal, AnimalDTO>().ReverseMap();
            CreateMap<Cage, CageDTO>().ReverseMap();
            CreateMap<Donation, DonationDTO>().ReverseMap();
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<EmployeeType, EmployeeTypeDTO>().ReverseMap();
            CreateMap<MedicalCare, MedicalCareDTO>().ReverseMap();
            CreateMap<MedicalJournal, MedicalJournalDTO>().ReverseMap();
            CreateMap<Visitor, VisitorDTO>().ReverseMap();
        }
    }
}
