using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.TL.DTO
{
    public class AnimalDTO
    {
        public int AnimalID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Race { get; set; }
        public int Age { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string OptionalDetails { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
