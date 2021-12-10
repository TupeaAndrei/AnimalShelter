using AnimalShelter.Authentification;
using AnimalShelter.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelter.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
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
                    return RedirectToAction("Index", "Home", new {Email = model.Email});
                    
                }

                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                ModelState.AddModelError(string.Empty, "Invalid login attempt!");
            }
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
                    return RedirectToAction("Index", "Home",new {Email = model.Email});
                }
                else
                {
                    var message = "Invalid";
                    
                    ViewData["Error"] = "Invalid login attempt.";
                   ModelState.AddModelError("Email", "Invalid login attempt.");
                   //return RedirectToAction("Login", "Account");
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
