using AnimalShelter.DAL.Entities;
using AnimalShelter.TL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.DAL.Interfaces
{
    public interface IMedicalJournalRepository
    {
        MedicalJournalDTO FindById(int id);
        List<MedicalJournalDTO> MedicalJournals { get; }
        void AddMedicalJournal(MedicalJournalDTO medicalJournal);
        void RemoveMedicalJournal(MedicalJournalDTO medicalJournal);
    }
}
