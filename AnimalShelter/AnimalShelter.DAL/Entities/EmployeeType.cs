using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.DAL.Entities
{
    public class EmployeeType
    {
        [Key]
        public int TypeID { get; set; }
        [Required]
        [MinLength(3,ErrorMessage ="This field min length is 3!")]
        public string Role { get; set; }
        [Required(ErrorMessage ="This field is required!")]
        [Range(0.0,9999.99,ErrorMessage ="Enter a valid value foor the salary!")]
        public double Salary { get; set; }
        [Required]
        [NotMapped]
        public List<string> Responsibilities { get; set; }

        [ForeignKey("Animal")]
        [Required]
        public int AnimalID { get; set; }
        public virtual Animal Animal { get; set; }

    }
}
