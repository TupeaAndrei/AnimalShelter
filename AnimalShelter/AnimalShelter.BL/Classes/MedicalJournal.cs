using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.BL.Classes
{
    public class MedicalJournal
    {
        [Key]
        public int JournalID { get; set; }
        public int AnimalID { get; set; }
        public DateTime Date { get; set; }
        public string Illness { get; set; }
        public List<String> Symptoms { get; set; }
        public List<String> Treatment { get; set; }
        public string OptionalDetails { get; set; }

        [ForeignKey("AnimalID")]
        public virtual Animal Animal { get; set; }

    }
}
