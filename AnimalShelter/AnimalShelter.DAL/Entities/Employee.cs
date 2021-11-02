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
    public class Employee : IEntity
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage ="This field is required!")]
        [MinLength(3,ErrorMessage = "Min length for this field is 3")]
        public string Name { get; set; }
        [Required(ErrorMessage ="This field is required!")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [Range(0, 99, ErrorMessage = "Please give a valid value for age!")]
        public int Age { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [MinLength(5, ErrorMessage = "Min length for this field is 5")]

        public string Address { get; set; }

        [ForeignKey("EmployeeType")]
        [Required]
        public int TypeID { get; set; }

        public virtual EmployeeType Type { get; set; }
    }
}
