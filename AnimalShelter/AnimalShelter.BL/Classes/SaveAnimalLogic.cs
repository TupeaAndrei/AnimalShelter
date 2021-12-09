using AnimalShelter.BL.Interfaces;
using AnimalShelter.DAL.Entities;
using AnimalShelter.DAL.Interfaces;
using AnimalShelter.TL.DTO;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.BL.Classes
{
    public class SaveAnimalLogic : ISaveAnimalLogic
    {
        private readonly IMapper _mapper;
        private readonly IAnimalShelterRepository<Animal> _animalRepository;
        private readonly IAnimalShelterRepository<MedicalCare> _careRepository;
        public async Task AddAnimal(AnimalDTO animalDTO)
        {
            if (animalDTO == null)
            {
                throw new ArgumentNullException(nameof(animalDTO));
            }
            try
            {
                var entity = _mapper.Map<Animal>(animalDTO);
                await _animalRepository.Add(entity);
            }
            catch (DbUpdateException)
            {
                throw;
            }
        }

        public async Task AddMedicalCare(AnimalDTO animalDTO,MedicalCareDTO medicalCareDTO)
        {
            if (animalDTO == null || medicalCareDTO == null)
            {
                throw new ArgumentNullException(nameof(animalDTO));
            }
            medicalCareDTO.AnimalID = animalDTO.AnimalID;
            try
            {
                var entity = _mapper.Map<MedicalCare>(medicalCareDTO);
                await _careRepository.Add(entity);
            }
            catch (DbUpdateException)
            {
                throw;
            }
        }
    }
}
