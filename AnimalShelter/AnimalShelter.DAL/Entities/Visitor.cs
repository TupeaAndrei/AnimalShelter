using AnimalShelter.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.DAL.Entities
{
    public class Visitor : IEntity
    {
        [Key]
        public int VisitorID { get; set; }
        [Required(ErrorMessage ="This field is required!")]
        [MinLength(3,ErrorMessage ="Name has to be at least 3 characters!")]
        public string Name { get; set; }
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        public string? PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Gender { get; set; }
    }

}
