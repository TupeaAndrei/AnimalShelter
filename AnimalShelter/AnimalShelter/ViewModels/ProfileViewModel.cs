using AnimalShelter.TL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelter.ViewModels
{
    public class ProfileViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public List<AdoptionPaperDTO> Adoptions { get; set; }
        public List<DonationDTO> Donations { get; set; }
    }
}
