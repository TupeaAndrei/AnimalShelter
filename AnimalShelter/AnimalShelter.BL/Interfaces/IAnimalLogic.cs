using AnimalShelter.TL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.BL.Interfaces
{
    public interface IAnimalLogic
    {
        Task AddAnimal(AnimalDTO animalDTO);
        Task RemoveAnimal(AnimalDTO animalDTO);
        Task UpdateAnimal(AnimalDTO animalDTO);
        Task AddMedicalCare(AnimalDTO animalDTO,MedicalCareDTO medicalCareDTO);
        Task<List<AnimalDTO>> GetAll();

        Task<AnimalDTO> GetByName(string name);
        Task BuildMedicalJournal(AnimalDTO animalDTO);
        
    }
}
