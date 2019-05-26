using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using OneDayFlat.Data;
using OneDayFlat.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using ElectionProject;
using ElectionProject.Models;
using System.Collections;
using OneDayFlat.ViewModels;
using System;
using System.Linq;
namespace OneDayFlat.Controllers
{
    public class AccountController : Controller
    {

        private ElectionContext db;
        public AccountController(ElectionContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(ViewModels.LoginModel model)
        {
            if (ModelState.IsValid)
            {
                Citizen user = await db.Citizen
                     .Include(u => u.Role)
                     .FirstOrDefaultAsync(u => u.Email == model.Login && u.Password == model.Password);
                if (user != null)
                {
                    await Authenticate(user);

                    return RedirectToAction("About", "Home");
                }
                ModelState.AddModelError("", "Некоректні логін і(або) пароль");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Register()
        {
          
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(ViewModels.RegisterModel model)
        {
            if (ModelState.IsValid)
            {

                var count = db.Citizen.Count();
                int id = (Int32)count;

                Citizen user = await db.Citizen.FirstOrDefaultAsync(u => u.Email == model.Email);
                if (user == null)
                {

                    user = new Citizen { Id = ++id, FirstName = model.FirstName, LastName = model.LastName, MiddleName = model.MiddleName,
                        Email = model.Email, BirthDate = System.DateTime.Parse(model.BirthDate), Ipn=model.Ipn, DistrictId=model.DistrictId, Password = model.Password };
                    Role userRole = await db.Role.FirstOrDefaultAsync(r => r.Name == "citizen");
                    if (userRole != null)
                    {
                        user.Role = userRole;
                    }
                    db.Citizen.Add(user);
                    await db.SaveChangesAsync();

                    await Authenticate(user);

                    return RedirectToAction("Login", "Account");
                }
                else
                    ModelState.AddModelError("", "Некоректні логін і(або) пароль");
            }
            return View(model);
        }

        private async Task Authenticate(Citizen user)
        {

            var claims = new List<Claim>
            {
                //new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role?.Name)
            };

            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
           
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

       
    }
}