using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.BL.Classes
{
    class Cage
    {
        [Key]
        public int CageID { get; set; }
        public int AnimalID { get; set; }
        public string Label { get; set; }
        public double Dimension { get; set; }

        [ForeignKey("AnimalID")]
        public virtual Animal Animal { get; set; }
        
    }
}
