using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.TL.DTO
{
    public class MedicalCareDTO
    {
        public int InterventionID { get; set; }
        public int EmployeeID { get; set; }
        public int AnimalID { get; set; }
        public DateTime Date { get; set; }
        public string Service { get; set; }
    }
}
