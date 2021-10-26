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
        [Required(ErrorMessage ="This field is required!")]
        [MinLength(3,ErrorMessage ="Name can't have less than 3 characters!")]
        public string Name { get; set; }
        [Required(ErrorMessage ="This field is required!")]
        [MinLength(3, ErrorMessage = "Name can't have less than 3 characters!")]
        public string Type { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [MinLength(3, ErrorMessage = "Name can't have less than 3 characters!")]
        public string Race { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [Range(0,99,ErrorMessage ="Please give a valid value for age!")]
        public int Age { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public DateTime RegistrationDate { get; set; }
        public string OptionalDetails { get; set; }
    }
}
