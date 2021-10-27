using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.DAL.Entities
{
    public class MedicalJournal
    {
        [Key]
        public int JournalID { get; set; }
        [ForeignKey("Animal")]
        [Required]
        public int AnimalID { get; set; }
        [Required]
        public DateTime Date { get; set; }
        /// <summary>
        /// Illness is optional, so if this is optional symptoms and treatment are optional as well, so this values are nullable.
        /// </summary>
        public string Illness { get; set; }
        [NotMapped]
        public List<String> Symptoms { get; set; }
        [NotMapped]
        public List<String> Treatment { get; set; }
        public string OptionalDetails { get; set; }

        public virtual Animal Animal { get; set; }

    }
}
