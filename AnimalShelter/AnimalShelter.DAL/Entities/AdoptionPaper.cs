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
    public class AdoptionPaper : IEntity
    {
        /// <summary>
        /// This table needs a primary key in order to be created in entity framework, even though in diagram it doesn't have one.
        /// </summary>
        [Key]
        public int Id { get; set; }
        public string AnimalName { get; set; }

        [ForeignKey("Visiter")]
        [Required]
        public int VisiterID { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public DateTime Date { get; set; }

        public virtual Visitor Visitor { get; set; }
        public string Adresss { get; set; }
        public string Town { get; set; }
        public string PostCode { get; set; }
        public string AdoptionReason { get; set; }
        public string? Allergy { get; set; }
        public int PetCount { get; set; }
        public string HouseType { get; set; }
        public string? Preparations { get; set; }

    }
}
