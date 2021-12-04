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
    public class AnimalLogic : IAnimalLogic
    {
        private readonly IAnimalShelterRepository<Animal> _animalRepository;
        private readonly IAnimalShelterRepository<MedicalCare> _careRepository;
        private readonly IAnimalShelterRepository<MedicalJournal> _medicalRepository;
        private readonly IMapper _mapper;

        public AnimalLogic(IAnimalShelterRepository<Animal> animalRepository, IAnimalShelterRepository<MedicalCare> careRepository, 
            IAnimalShelterRepository<MedicalJournal> medicalRepository, IMapper mapper)
        {
            _animalRepository = animalRepository;
            _careRepository = careRepository;
            _medicalRepository = medicalRepository;
            _mapper = mapper;
        }

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
            catch(DbUpdateException)
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
            catch(DbUpdateException)
            {
                throw;
            }
        }

        public Task BuildMedicalJournal(AnimalDTO animalDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AnimalDTO>> GetAll()
        {
            var results = _mapper.Map<List<AnimalDTO>>(await _careRepository.GetAll());
            return results;
        }

        public async Task RemoveAnimal(AnimalDTO animalDTO)
        {
            if (animalDTO == null)
            {
                throw new ArgumentNullException(nameof(animalDTO));
            }
            try
            {
                await _animalRepository.Delete(animalDTO.AnimalID);
            }
            catch(DbUpdateException)
            {
                throw;
            }
        }

        public async Task UpdateAnimal(AnimalDTO animalDTO)
        {
            if (animalDTO == null)
            {
                throw new ArgumentNullException(nameof(animalDTO));
            }
            try
            {
                var entity = _mapper.Map<Animal>(animalDTO);
                await _animalRepository.Update(entity);
            }
            catch(DbUpdateException)
            {
                throw;
            }
        }
    }
}
