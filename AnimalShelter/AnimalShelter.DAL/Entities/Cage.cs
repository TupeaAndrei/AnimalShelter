using AnimalShelter.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.DAL.Entities
{
    public class Cage : IEntity
    {
        [Key]
        public int CageID { get; set; }
        [Required]
        [ForeignKey("Animal")]
        public int AnimalID { get; set; }
        [Required(ErrorMessage ="This field is required!")]
        public string Label { get; set; }
        [Required(ErrorMessage ="This field is required!")]
        [Range(0.0,99.99, ErrorMessage ="Please enter a valid value for the dimensions of the cage!")]
        public double Dimension { get; set; }

        public virtual Animal Animal { get; set; }
        
    }
}
