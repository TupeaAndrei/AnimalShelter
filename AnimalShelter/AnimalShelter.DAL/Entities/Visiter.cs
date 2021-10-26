using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.DAL.Entities
{
    public class Visiter
    {
        [Key]
        public int VisiterID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
