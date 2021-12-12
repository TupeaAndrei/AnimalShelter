using AnimalShelter.Authentification;
using AnimalShelter.BL.Interfaces;
using AnimalShelter.TL.DTO;
using AnimalShelter.ViewModels;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelter.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly INotyfService _notyf;
        private readonly IVisitorLogic _visitorLogic;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager,INotyfService notyf,IVisitorLogic visitorLogic)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _notyf = notyf;
            _visitorLogic = visitorLogic;
        }

        public IActionResult Register()
        {
            return View(new RegisterModel { ConfirmPassword = "", Email = "", Password = "" });
        }

        public async Task<IActionResult> ConfirmRegister(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                };

                var result =  await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    try
                    {
                        var dto = new VisitorDTO { Email = model.Email, Name = model.UserName ,PhoneNumber = model.PhoneNumber};
                        await _visitorLogic.AddVisitor(dto);
                    }
                    catch(DataException)
                    {
                        _notyf.Error("DB ERROR");
                        return RedirectToAction("Register", "Account");
                    }
                    _notyf.Success("Register Succeded!");

                    return RedirectToAction("Index", "Home", new {Email = model.Email});
                    
                }
                string lastError = "";
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                    lastError = error.Description;
                    _notyf.Error(error.Code);

                }
                _notyf.Error(lastError);
                ModelState.AddModelError(string.Empty, "Invalid login attempt!");
            }
            _notyf.Error("Password dont match!");
            return RedirectToAction("Register", "Account");
        }

        public IActionResult Login()
        {
            return View(new LoginModel { Email="",Password=""});
        }

        public async Task<IActionResult> ConfirmLogin(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, true, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    _notyf.Success("Login succsesfull!");
                    return RedirectToAction("Index", "Home",new {Email = model.Email});
                }
                else
                {
                    _notyf.Error("Invalid login attempt!");
                   return RedirectToAction("Login", "Account");
                }
            }

            // If we got this far, something failed, redisplay form
            return RedirectToAction("Login", "Account");
        }

        public IActionResult Index()
        {
            return View();
        }

      
    }
}
