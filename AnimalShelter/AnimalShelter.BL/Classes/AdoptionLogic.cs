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
    public class AdoptionLogic : IAdoptionLogic
    {
        private readonly IAnimalShelterRepository<Animal> _animalRepository;
        private readonly IAnimalShelterRepository<MedicalJournal> _medicalRepository;
        private readonly IAnimalShelterRepository<AdoptionPaper> _adoptionRepository;
        private readonly IAnimalShelterRepository<Employee> _employeeRepository;
        private readonly IAnimalShelterRepository<EmployeeType> _typeRepository;
        private readonly IMapper _mapper;

        public AdoptionLogic(IAnimalShelterRepository<Animal> animalRepository, IAnimalShelterRepository<MedicalJournal> medicalRepository,
            IAnimalShelterRepository<AdoptionPaper> adoptionRepository,
            IAnimalShelterRepository<Employee> employeeRepository, IAnimalShelterRepository<EmployeeType> typeRepository, IMapper mapper)
        {
            _animalRepository = animalRepository;
            _medicalRepository = medicalRepository;
            _adoptionRepository = adoptionRepository;
            _employeeRepository = employeeRepository;
            _typeRepository = typeRepository;
            _mapper = mapper;
        }

        public async Task FinishAdoptionProcess(AdoptionPaperDTO adoptionPaperDTO, AnimalDTO animalDTO)
        {
            try
            {
                await AddAdoptionPaper(adoptionPaperDTO);
                await RemoveAnimalFromShelter(animalDTO);
            }
            catch (DbUpdateException)
            {
                throw;
            }
        }

        public async Task AddAdoptionPaper(AdoptionPaperDTO adoptionPaperDTO)
        {
            if (adoptionPaperDTO == null)
            {
                throw new ArgumentNullException(nameof(adoptionPaperDTO));
            }
            var entity = _mapper.Map<AdoptionPaper>(adoptionPaperDTO);
            try
            {
                await _adoptionRepository.Add(entity);
            }
            catch(DbUpdateException)
            {
                throw;
            }
        }

        public async Task<List<MedicalJournalDTO>> GetMedicalJournalDTOForAnimal(AnimalDTO animalDTO)
        {
            if (animalDTO == null)
            {
                throw new ArgumentNullException(nameof(animalDTO));
            }
            var results = await _medicalRepository.GetAll();
            var match = results.Where(mj => mj.AnimalID == animalDTO.AnimalID).ToList();
            if (match == null)
            {
                throw new ArgumentNullException(nameof(results));
            }
            var finalResults = _mapper.Map<List<MedicalJournalDTO>>(match);
            return finalResults;
        }

        public async Task<EmployeeDTO> GetResponsibleEmployee(AnimalDTO animalDTO)
        {
            if (animalDTO == null)
            {
                throw new ArgumentNullException(nameof(animalDTO));
            }
            var types = await _typeRepository.GetAll();
            var finalTypes = types.FirstOrDefault(t => t.AnimalID == animalDTO.AnimalID);
            if (finalTypes == null)
            {
                throw new Exception("No employees found");
            }
            var employees = await _employeeRepository.GetAll();
            var finalEmployee = employees.FirstOrDefault(e => e.TypeID == finalTypes.TypeID);
            if (finalEmployee == null)
            {
                throw new Exception("No employee found!");
            }
            var result = _mapper.Map<EmployeeDTO>(finalEmployee);
            return result;
        }

        public async Task RemoveAnimalFromShelter(AnimalDTO animalDTO)
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
    }
}
