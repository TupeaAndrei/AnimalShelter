using AnimalShelter.TL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.BL.Interfaces
{
    public interface IDonationLogic
    {
        public Task AddDonation(DonationDTO donationDTO);
        public Task RemoveDonation(DonationDTO donationDTO);
        public Task<DonationDTO> GetById(int id);
        public Task<List<DonationDTO>> GetDonations();

    }
}
