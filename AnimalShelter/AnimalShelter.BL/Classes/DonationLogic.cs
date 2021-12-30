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
    public class DonationLogic : IDonationLogic
    {
        private readonly IAnimalShelterRepository<Donation> _donationRepository;
        private readonly IMapper _mapper;

        public DonationLogic(IAnimalShelterRepository<Donation> donationRepository, IMapper mapper)
        {
            _donationRepository = donationRepository;
            _mapper = mapper;
        }

       

        public  async Task AddDonation(DonationDTO donationDTO)
        {
            var donation = _mapper.Map<Donation>(donationDTO);
            try
            {
                 await _donationRepository.Add(donation);
            }
            catch(DataException)
            {
                throw;
            }
        }

        public async Task<DonationDTO> GetById(int id)
        {
            Donation donation = new();
            try
            {
                donation = await _donationRepository.FindById(id);
            }
            catch(DataException)
            {
                throw;
            }
            var donationDTO = _mapper.Map<DonationDTO>(donation);
            return donationDTO;
        }

        public async Task<List<DonationDTO>> GetDonations()
        {
            var results = await _donationRepository.GetAll();
            var dtos = _mapper.Map<List<DonationDTO>>(results);
            return dtos;
        }

        public async Task<List<DonationDTO>> GetDonationsFromUser(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ArgumentNullException(nameof(id));
                }
                var results = await _donationRepository.GetAll();
                var finalResults = results.Where(a => a.VisitorID == id).ToList();
                if (finalResults == null)
                {
                    throw new DbUpdateException();
                }
                return _mapper.Map<List<DonationDTO>>(finalResults);
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (DbUpdateException)
            {
                throw;
            }
        }

        public async Task RemoveDonation(DonationDTO donationDTO)
        {
            try
            {
                await _donationRepository.Delete(donationDTO.DonationID);
            }
            catch(DbUpdateException)
            {
                throw;
            }
        }
    }
}
