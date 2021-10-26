using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.TL.DTO
{
    public class AdoptionPaperDTO
    {
        public int Id { get; set; }
        public int AnimalID { get; set; }
        public int VisiterID { get; set; }
        public DateTime Date { get; set; }
    }
}
