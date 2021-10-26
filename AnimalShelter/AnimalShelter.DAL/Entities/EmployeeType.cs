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
        public string Role { get; set; }
        public double Salary { get; set; }
        public List<string> Responsibilities { get; set; }

        [ForeignKey("Animal")]
        public int AnimalID { get; set; }
        public virtual Animal Animal { get; set; }

    }
}
