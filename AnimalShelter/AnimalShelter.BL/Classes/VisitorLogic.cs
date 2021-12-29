using AnimalShelter.BL.Interfaces;
using AnimalShelter.DAL.Entities;
using AnimalShelter.DAL.Interfaces;
using AnimalShelter.DAL.Repositories;
using AnimalShelter.TL.DTO;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.BL.Classes
{
    public class VisitorLogic : IVisitorLogic
    {
        private readonly IMapper _mapper;
        private readonly IAnimalShelterRepository<Visitor> _visitorRepository;

        public VisitorLogic(IMapper mapper, IAnimalShelterRepository<Visitor> visitorRepository)
        {
            _mapper = mapper;
            _visitorRepository = visitorRepository;
        }

        public async Task<VisitorDTO> AddVisitor(VisitorDTO visitorDTO)
        {
            if (visitorDTO == null)
            {
                throw new ArgumentNullException(nameof(visitorDTO));
            }
            try
            {
                var entity = _mapper.Map<Visitor>(visitorDTO);
                var result = await _visitorRepository.Add(entity);
                var resultDTO = _mapper.Map<VisitorDTO>(result);
                return resultDTO;
            }
            catch(DbUpdateException)
            {
                throw;
            }
        }

        public async Task<VisitorDTO> GetVisitorByNameAndEmail(string name, string email)
        {
            List<Visitor> visitors = new();
            Visitor visitor = new();
            try
            {
                visitors = await _visitorRepository.GetAll();
                visitor = visitors.FirstOrDefault(v => v.Name == name && v.Email == email);

            }
            catch (DataException)
            {
                throw;
            }
            var visitorDTO = _mapper.Map<VisitorDTO>(visitor);
            return visitorDTO;
        }

        public async Task<VisitorDTO> GetVisitorByEmail(string email)
        {
            List<Visitor> visitors = new();
            Visitor visitor = new();
            try
            {
                visitors = await _visitorRepository.GetAll();
                visitor = visitors.FirstOrDefault(v => v.Email == email);
                if (visitor == null)
                {
                    throw new ArgumentNullException(nameof(visitor));
                }
                return _mapper.Map<VisitorDTO>(visitor);
            }
            catch(ArgumentNullException)
            {
                throw;
            }
            catch(DbUpdateException)
            {
                throw;
            }
        }

        public async Task RemoveVisitor(VisitorDTO visitorDTO)
        {
            if (visitorDTO == null)
            {
                throw new ArgumentNullException(nameof(visitorDTO));
            }
            try
            {
                await _visitorRepository.Delete(visitorDTO.VisitorID);
            }
            catch(DbUpdateException)
            {
                throw;
            }
        }
    }
}
