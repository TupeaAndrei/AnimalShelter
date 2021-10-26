using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.DAL.Entities
{
    public class Animal
    {
        [Key]
        public int AnimalID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Race { get; set; }
        public int Age { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string OptionalDetails { get; set; }
    }
}
