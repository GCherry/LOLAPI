using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading;
using System.Web.Mvc;
using WebMatrix.WebData;
using System.Web;

namespace LOLAPI.Shared
{
    public class LoginFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var context = filterContext.HttpContext;
            if (context.Session["UserID"] == null)
            {

                string redirectTo = "~/UserAccount/Register";
                redirectTo = string.Format("~/UserAccount/Register?ReturnUrl={0}",
                                HttpUtility.UrlEncode(context.Request.RawUrl));

                filterContext.Result = new RedirectResult(redirectTo);
                //if (context.Session.IsNewSession)
                //{
                //    string sessionCookie = context.Request.Headers["Cookie"];

                //    if ((sessionCookie != null) && (sessionCookie.IndexOf("ASP.NET_SessionId") >= 0))
                //    {

                //        string redirectTo = "~/UserAccount/Register";
                //        if (!string.IsNullOrEmpty(context.Request.RawUrl))
                //        {
                //            redirectTo = string.Format("~/Account/Logon?ReturnUrl={0}",
                //                HttpUtility.UrlEncode(context.Request.RawUrl));
                //        }
                //        filterContext.Result = new RedirectResult(redirectTo);
                //    }
                //}
            }

            base.OnActionExecuting(filterContext);
        }
    }
}
