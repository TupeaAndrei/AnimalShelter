using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.DAL.Entities
{
    public class AdoptionPaper
    {
        [ForeignKey("Animal")]
        public int AnimalID { get; set; }

        [ForeignKey("Visiter")]
        public int VisiterID { get; set; }

        public DateTime Date { get; set; }

        public virtual Animal Animal { get; set; }
        public virtual Visiter Visiter { get; set; }

    }
}
