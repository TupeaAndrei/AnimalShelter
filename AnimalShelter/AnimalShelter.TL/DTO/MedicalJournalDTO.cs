using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.TL.DTO
{
    public class MedicalJournalDTO
    {
        public int JournalID { get; set; }
        public int AnimalID { get; set; }
        public DateTime Date { get; set; }
        public string Illness { get; set; }
        public List<String> Symptoms { get; set; }
        public List<String> Treatment { get; set; }
        public string OptionalDetails { get; set; }
    }
}
