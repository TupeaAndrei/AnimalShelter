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
        public int? EmployeeID { get; set; }

        [ForeignKey("Animal")]
        [Required]
        public int AnimalID { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required(ErrorMessage ="This field is required!")]
        [MinLength(3,ErrorMessage ="This field min length is 3")]
        public string Service { get; set; }

        public virtual Animal Animal { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
