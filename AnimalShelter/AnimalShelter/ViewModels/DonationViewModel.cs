using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelter.ViewModels
{
    public class DonationViewModel
    {
        public int DonationSum { get; set; } = 1;
        public bool MakeDonation { get; set; } = false;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? OptionalInfo { get; set; }
        public bool Terms { get; set; } = false;
        public List<string> PaymentMethods { get; set; } = new List<string> { "Visa", "Paypal", "MasterCard", "Bitcoin" };
        public string SelectedPaymentMethod { get; set; }
    }
}
