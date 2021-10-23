using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.BL.Classes
{
    public class AdoptionPaper
    {
        [ForeignKey("AnimalID")]
        public int AnimalID { get; set; }

        [ForeignKey("VisiterID")]
        public int VisiterID { get; set; }

        public DateTime Date { get; set; }

        public virtual Animal Animal { get; set; }
        public virtual Visiter Visiter { get; set; }

    }
}
