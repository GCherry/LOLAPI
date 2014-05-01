using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LOLAPI.Shared.Entities;
using LOLAPI.Shared.Interfaces;
using LOLAPI.Logic;
using System.Security.Cryptography;

namespace LOLAPI.Web.Controllers
{
    public class UserAccountController : Controller
    {

        private readonly IUserManager _userManager;

        //Dependency injection using the NinjectWebCommon.cs file to bind the User manager classes
        UserAccountController(IUserManager manager)
        {
            _userManager = manager;
        }

        // GET: /UserAccount/

        public ActionResult Index()
        {
            if (Session["UserID"] == null)
            {
                return View("");
            }
            else
            {
                return View();
            }            
        }

        public ActionResult Login()
        {

            return View();
        }

        public ActionResult Register()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterUser(UserAccount userAccount, string confirmPassword)
        {

            //Check if user already exists
            UserAccount checkUser = _userManager.GetOneByEmail(userAccount.Email);   
            
            if (checkUser != null)
            {
                //A account with this email already exists
            }
            else
            {

                //Make sure passwords match then hash them
                if (confirmPassword == userAccount.Password)
                {
                    //Hash the password

                    //Add new user
                    UserAccount newUser = _userManager.Add(userAccount);
                }
                
            }
            
            return View();
        }

    }
}
