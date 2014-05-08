using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LOLAPI.Shared.Entities;
using LOLAPI.Shared.Interfaces;
using LOLAPI.Logic;
using System.Security.Cryptography;
using System.Web.Security;
using DotNetOpenAuth.AspNet;
using Microsoft.Web.WebPages.OAuth;
using WebMatrix.WebData;
using System.Text;

namespace LOLAPI.Web.Controllers
{
    public class UserAccountController : Controller
    {

        private readonly IUserManager _userManager;

        //Dependency injection using the NinjectWebCommon.cs file to bind the User manager classes
        public UserAccountController(IUserManager manager)
        {
            _userManager = manager;
        }

        // GET: /UserAccount/

        public ActionResult Index()
        {

            //return strBuilder.ToString();
            if (Session["UserID"] == null)
            {
                return View("Login");
            }
            else
            {
                return View("ManageUserAccount");
            }

        }

        public ActionResult Login()
        {

            return View("Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserAccount userAccount)
        {

            if (ModelState.IsValid && WebSecurity.Login(userAccount.UserName, userAccount.Password))
            {
                Boolean usersLoggedIn = _userManager.LogInUser(userAccount);
   
            }

            //Get the login information and make sure it matches
            Boolean userLoggedIn = _userManager.LogInUser(userAccount);

            if (userLoggedIn == true)
            {
                UserAccount userLogin = _userManager.GetOneByEmail(userAccount.Email);
                Session["UserID"] = userLogin.Id;
            }

            return View("Login");
        }

        public ActionResult Register()
        {

            return View("Register");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterUser(UserAccount userAccount, string confirmPassword)
        {

            //Check if user already exists
            UserAccount checkUser = _userManager.GetOneByEmail(userAccount.Email);   
            
            if (checkUser != null)
            {
                //A account with this email already exists message
                return View("Login");
            }
            else
            {

                //Make sure passwords match then hash them
                if (confirmPassword == userAccount.Password)
                {
                    //Hash the password
                    userAccount.Password = _userManager.GetHashedPassword(userAccount.Password);

                    //Add new user
                    UserAccount newUser = _userManager.Add(userAccount);

                    //If User was successfully added return the user to the login screen
                    return View("Login");
                }
                else
                {
                    //Message that passwords dont match

                    return View("Register");
                }
                
            }

        }

    }
}
