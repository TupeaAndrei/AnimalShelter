using AnimalShelter.TL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.BL.Interfaces
{
    public interface ISaveAnimalLogic
    {
        Task AddAnimal(AnimalDTO animalDTO);
        Task AddMedicalCare(AnimalDTO animalDTO,MedicalCareDTO medicalCareDTO);
    }
}
