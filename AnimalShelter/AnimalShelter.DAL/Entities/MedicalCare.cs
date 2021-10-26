using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.DAL.Entities
{
    public class MedicalCare
    {
        [Key]
        public int InterventionID { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }

        [ForeignKey("Animal")]
        public int AnimalID { get; set; }

        public DateTime Date { get; set; }
        public string Service { get; set; }

        public virtual Animal Animal { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
