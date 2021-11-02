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
        [ForeignKey("Animal")]
        public int AnimalID { get; set; }

        [ForeignKey("Visiter")]
        [Required]
        public int VisiterID { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public DateTime Date { get; set; }

        public virtual Animal Animal { get; set; }
        public virtual Visitor Visitor { get; set; }

    }
}
