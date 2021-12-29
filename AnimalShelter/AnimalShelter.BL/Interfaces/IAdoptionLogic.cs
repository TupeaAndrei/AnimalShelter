using AnimalShelter.TL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.BL.Interfaces
{
    public interface IAdoptionLogic
    {
        public Task AddAdoptionPaper(AdoptionPaperDTO adoptionPaperDTO);
        public Task RemoveAnimalFromShelter(AnimalDTO animalDTO);
        public Task<List<MedicalJournalDTO>> GetMedicalJournalDTOForAnimal(AnimalDTO animalDTO);
        public Task<EmployeeDTO> GetResponsibleEmployee(AnimalDTO animalDTO);
        public Task FinishAdoptionProcess(AdoptionPaperDTO adoptionPaperDTO, AnimalDTO animalDTO);
        public Task<List<AdoptionPaperDTO>> GetVisitorsAdoptions(int id);
    }
}
