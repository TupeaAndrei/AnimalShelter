using AnimalShelter.BL.Interfaces;
using AnimalShelter.TL.DTO;
using AnimalShelter.ViewModels;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelter.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IVisitorLogic _visitorLogic;
        private readonly IAdoptionLogic _adoptionLogic;
        private readonly IDonationLogic _donationLogic;
        private readonly INotyfService _notyf;

        public ProfileController(IVisitorLogic visitorLogic, IAdoptionLogic adoptionLogic, IDonationLogic donationLogic, INotyfService notyf)
        {
            _visitorLogic = visitorLogic;
            _adoptionLogic = adoptionLogic;
            _donationLogic = donationLogic;
            _notyf = notyf;
        }

        public async Task<IActionResult> Index()
        {
            VisitorDTO currentUser = new();
            List<AdoptionPaperDTO> adoptions = new();
            List<AdoptionPaperDTO> hostings = new();
            List<DonationDTO> donations = new();
            try
            {
                currentUser = await _visitorLogic.GetVisitorByEmail(this.User.Identity.Name);
                adoptions = await _adoptionLogic.GetVisitorsAdoptions(currentUser.VisitorID);
                hostings = await _adoptionLogic.GetVisitorsHostings(currentUser.VisitorID);
                donations = await _donationLogic.GetDonationsFromUser(currentUser.VisitorID);
            }
            catch(ArgumentNullException)
            {
                _notyf.Error("Something went wrong while loading the page!");
                return RedirectToAction("Index", "Home");
            }
            catch(DbUpdateException)
            {
                _notyf.Error("Something went wrong while loading the page!");
                return RedirectToAction("Index", "home");
            }
            var model = new ProfileViewModel() {Email = this.User.Identity.Name, Name = currentUser.Name,PhoneNumber = currentUser.PhoneNumber,Adoptions = adoptions ,Donations = donations, Hostings = hostings};
            return View(model);
        }
    }
}
