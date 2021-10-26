using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.TL.DTO
{
    public class EmployeeTypeDTO
    {
        public int TypeID { get; set; }
        public string Role { get; set; }
        public double Salary { get; set; }
        public List<string> Responsibilities { get; set; }
        public int AnimalID { get; set; }
      
    }
}
