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
    public class Donation : IEntity
    {
        [Key]
        public int DonationID { get; set; }
        public double Sum { get; set; }
        public DateTime Date { get; set; }
        public string PaymentMethod { get; set; }

        [ForeignKey("Visitor")]
        public int VisitorID { get; set; }

        public virtual Visitor Visitor { get; set; }
    }
}
