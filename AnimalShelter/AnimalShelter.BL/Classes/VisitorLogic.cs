using AnimalShelter.BL.Interfaces;
using AnimalShelter.DAL.Entities;
using AnimalShelter.DAL.Interfaces;
using AnimalShelter.DAL.Repositories;
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
    public class VisitorLogic : IVisitorLogic
    {
        private readonly IMapper _mapper;
        private readonly IAnimalShelterRepository<Visitor> _visitorRepository;

        public VisitorLogic(IMapper mapper, IAnimalShelterRepository<Visitor> visitorRepository)
        {
            _mapper = mapper;
            _visitorRepository = visitorRepository;
        }

        public async Task AddVisitor(VisitorDTO visitorDTO)
        {
            if (visitorDTO == null)
            {
                throw new ArgumentNullException(nameof(visitorDTO));
            }
            try
            {
                var entity = _mapper.Map<Visitor>(visitorDTO);
                await _visitorRepository.Add(entity);
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
