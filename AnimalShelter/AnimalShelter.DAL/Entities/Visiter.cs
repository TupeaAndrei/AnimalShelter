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
        [Required(ErrorMessage ="This field is required!")]
        [MinLength(3,ErrorMessage ="Name has to be at least 3 characters!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        public string PhoneNumber { get; set; }
    }
}
