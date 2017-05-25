using AddressBook.Models;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace AddressBook.Controllers
{
    public class AccountController : Controller
    {


        public IAuthenticationManager AuthManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model, string returnUrl)
        {
            //Perform authentication

            //Sign user in
            if (ModelState.IsValid)
            {
                if (model.Email == "admin@gmail.com" && model.Password == "1111")
                {
                    SignIn(model);

                    //Redirect to return url
                    return RedirectToAction("index", "home");

                    //if (!string.IsNullOrEmpty(returnUrl))
                    //    return Redirect(returnUrl);
                    //else
                }
                else
                    //Return view with error msg
                    return View(model);
            }
            return View(model);
        }

        private void SignIn(LoginModel model)
        {
            Claim[] claims = new Claim[] {
                                new Claim(ClaimTypes.NameIdentifier, "1"),
                                new Claim(ClaimTypes.Name, model.Email),
                                new Claim(ClaimTypes.Email, model.Email),
                                //new Claim(ClaimTypes.Role, "Admin")
                            };
            var claimsIdentity = new ClaimsIdentity(claims, DefaultAuthenticationTypes.ApplicationCookie);

            AuthManager.SignIn(claimsIdentity);
        }

        public ActionResult LogOut()
        {
            AuthManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("login");
        }
    }
}