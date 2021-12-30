using AnimalShelter.TL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelter.ViewModels
{
    public class AdoptionViewModel
    {
        public DateTime CurrentDate { get; set; }
        public List<string> Animals { get; set; }
        public string SelectedAnimal { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Adress { get; set; }
        public string Town { get; set; }
        public string PostCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int? Age { get; set; }
        public string AdoptionReaseon { get; set; }
        public string Allergic { get; set; }
        public int PetCount { get; set; }
        public string HouseType { get; set; }
        public string? Preparations { get; set; }
    }
}
