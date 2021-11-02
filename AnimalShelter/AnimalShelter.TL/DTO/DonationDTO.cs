using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.TL.DTO
{
    public class DonationDTO
    {
        public int DonationID { get; set; }
        public double Sum { get; set; }
        public DateTime Date { get; set; }
        public string PaymentMethod { get; set; }
        public int VisitorID { get; set; }
    }
}
