using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.TL.DTO
{
    public class CageDTO
    {
        public int CageID { get; set; }
        public int AnimalID { get; set; }
        public string Label { get; set; }
        public double Dimension { get; set; }
    }
}
