using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LOLAPI.Shared.Entities;
using LOLAPI.Shared.Interfaces;
using LOLAPI.Logic;

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

    }
}
