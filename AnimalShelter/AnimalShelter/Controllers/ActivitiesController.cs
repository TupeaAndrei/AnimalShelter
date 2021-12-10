using Microsoft.AspNetCore.Mvc;

namespace AnimalShelter.Controllers
{
    public class ActivitiesController : Controller
    {
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
            return View();
        }
    }
}
