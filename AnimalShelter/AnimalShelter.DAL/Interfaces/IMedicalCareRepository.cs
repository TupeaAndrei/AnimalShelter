using AnimalShelter.DAL.Entities;
using AnimalShelter.TL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.DAL.Interfaces
{
    public interface IMedicalCareRepository
    {
        MedicalCareDTO FindById(int id);
        List<MedicalCareDTO> MedicalCareList { get; }
        void AddMedicalCare(MedicalCareDTO medicalCare);
        void RemoveMedicalCare(MedicalCareDTO medicalCare);
    }
}
