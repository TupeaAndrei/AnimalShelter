using AnimalShelter.BL.Interfaces;
using AnimalShelter.TL.DTO;
using AnimalShelter.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AnimalShelter.Controllers
{
    public class ActivitiesController : Controller
    {
        private readonly IDonationLogic _donationLogic;
        private readonly IVisitorLogic _visitorLogic;

        public ActivitiesController(IDonationLogic donationLogic, IVisitorLogic visitorLogic)
        {
            _donationLogic = donationLogic;
            _visitorLogic = visitorLogic;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Adopt()
        {
            return View();
        }

        public IActionResult Donate()
        {
            var model = new DonationViewModel();
            model.Email = this.User.Identity.Name;
            return View(model);
        }

        public async Task<IActionResult> ConfirmDonation(DonationViewModel model)
        {
            if (ModelState.IsValid)
            {
                var visitor = await _visitorLogic.GetVisitorByNameAndEmail(model.FirstName, model.Email);
                int id = 0;
                if (visitor == null)
                {
                    var visitorDTO = new VisitorDTO { Name = model.FirstName, Email = model.Email };
                    var result = await _visitorLogic.AddVisitor(visitorDTO);
                    id = result.VisitorID;
                   
                }
                if (visitor != null)
                {
                    id = visitor.VisitorID;
                }
                var donationDTO = new DonationDTO { Date = System.DateTime.Now, Sum = model.DonationSum, PaymentMethod = model.SelectedPaymentMethod,VisitorID = id };
                await _donationLogic.AddDonation(donationDTO);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
