using AnimalShelter.BL.Interfaces;
using AnimalShelter.TL.DTO;
using AnimalShelter.ViewModels;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AnimalShelter.Controllers
{
    public class ActivitiesController : Controller
    {
        private readonly IDonationLogic _donationLogic;
        private readonly IVisitorLogic _visitorLogic;
        private readonly INotyfService _notyf;
        private readonly IAnimalLogic _animalLogic;
        private readonly IAdoptionLogic _adoptionLogic;

        public ActivitiesController(IDonationLogic donationLogic, IVisitorLogic visitorLogic,INotyfService notyf, IAnimalLogic animalLogic,IAdoptionLogic adoptionLogic)
        {
            _donationLogic = donationLogic;
            _visitorLogic = visitorLogic;
            _notyf = notyf;
            _animalLogic = animalLogic;
            _adoptionLogic = adoptionLogic;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Hotel()
        {
            var model = new AdoptionViewModel();
            if (this.User.Identity.Name != null)
            {
                model.Email = this.User.Identity.Name;
            }
            model.CurrentDate = new System.DateTime();
            return View(model);
        }

        public async Task<IActionResult> Adopt()
        {
            var animals = await _animalLogic.GetAll();
            List<string> names = new List<string>();
            foreach (var item in animals)
            {
                names.Add(item.Name);
            }
            var model = new AdoptionViewModel { Animals = names };
            if (this.User.Identity.Name != null)
            {
                model.Email = this.User.Identity.Name;
            }
            model.CurrentDate = new System.DateTime();
            return View(model);
        }

        public async Task<IActionResult> ConfirmAdoption(AdoptionViewModel model)
        {
            if (ModelState.IsValid)
            {
                var day = Request.Form["day"];
                var month = Request.Form["month"];
                var year = Request.Form["year"];
                var date = new System.DateTime(int.Parse(year),int.Parse(month), int.Parse(day));
                VisitorDTO visitor = new();
                AnimalDTO animal = new();
                try
                {
                    visitor = await _visitorLogic.GetVisitorByNameAndEmail(model.FirstName, model.Email);
                    animal = await _animalLogic.GetByName(model.SelectedAnimal);
                }
                catch(DbUpdateException)
                {
                    if (animal == null)
                    {
                        _notyf.Error("Database search returned no results for this animal");
                        return RedirectToAction("Index", "Home");
                    }
                    if (visitor == null)
                    {
                        _notyf.Error("Database search returned no results for this visitor");
                        return RedirectToAction("Index", "Home");
                    }
                }
                var adoptionPaper = new AdoptionPaperDTO
                {
                    AdoptionReason = model.AdoptionReaseon,
                    PetCount = model.PetCount,
                    PostCode = model.PostCode,
                    Adresss = model.Adress,
                    Allergy = model.Allergic,
                    VisiterID = visitor.VisitorID,
                    Date = date,
                    HouseType = model.HouseType,
                    Preparations = model.Preparations,
                    Town = model.Town,
                    AnimalName = model.SelectedAnimal
                };
                try
                {
                    await _adoptionLogic.FinishAdoptionProcess(adoptionPaper, animal);
                }
                catch(DbUpdateException)
                {
                    _notyf.Error("Something went wrong");
                    return RedirectToAction("Index", "Home");
                }
                _notyf.Success("Enjoy your day and Thank you!");
                return RedirectToAction("Index", "Home");
            }
            _notyf.Error("Something went wrong");
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> ConfirmHotel(AdoptionViewModel model)
        {
            if (ModelState.IsValid)
            {
                var day = Request.Form["day"];
                var month = Request.Form["month"];
                var year = Request.Form["year"];
                var date = new System.DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
                VisitorDTO visitor = new();
                AnimalDTO animal = new AnimalDTO { Age = 1, Name = model.SelectedAnimal, RegistrationDate = model.CurrentDate, OptionalDetails = model.Preparations, Race = "Unknown", Type = "House animal" };
                try
                {
                    visitor = await _visitorLogic.GetVisitorByEmail(model.Email);
                }
                catch (DbUpdateException)
                {
                    if (visitor == null)
                    {
                        _notyf.Error("Database search returned no results for this visitor");
                        return RedirectToAction("Index", "Home");
                    }
                }
                var adoptionPaper = new AdoptionPaperDTO
                {
                    AdoptionReason = model.AdoptionReaseon,
                    PostCode = model.PostCode,
                    Adresss = model.Adress,
                    VisiterID = visitor.VisitorID,
                    Date = date,
                    HouseType = model.HouseType,
                    Preparations = model.Preparations,
                    Town = model.Town,
                    AnimalName = model.SelectedAnimal,
                    Hosting = "Yes"
                };
                try
                {
                    await _adoptionLogic.AddAdoptionPaper(adoptionPaper);
                }
                catch (DbUpdateException)
                {
                    _notyf.Error("Something went wrong");
                    return RedirectToAction("Index", "Home");
                }
                _notyf.Success("Enjoy your day and Thank you!");
                return RedirectToAction("Index", "Home");
            }
            _notyf.Error("Something went wrong");
            return RedirectToAction("Index", "Home");
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
            _notyf.Success("Thank you for you donation! You Are Awesome!");
            return RedirectToAction("Index", "Home");
        }


    }
}
