using AnimalShelter.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelter.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View(new RegisterModel{ConfirmPassword="",Email="",Password="" });
        }
    }
}
