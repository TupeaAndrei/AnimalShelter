using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.TL.DTO
{
    public class AdoptionPaperDTO
    {
        public int Id { get; set; }
        public int AnimalID { get; set; }
        public int VisiterID { get; set; }
        public DateTime Date { get; set; }
        public string Adresss { get; set; }
        public string Town { get; set; }
        public string PostCode { get; set; }
        public string AdoptionReason { get; set; }
        public string? Allergy { get; set; }
        public int PetCount { get; set; }
        public string HouseType { get; set; }
        public string? Preparations { get; set; }
    }
}
