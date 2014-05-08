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

namespace LOLAPI.Shared
{
    public class LoginFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //var context = filterContext.HttpContext;
            //if (context.Session != null)
            //{
            //    if (context.Session.IsNewSession)
            //    {
            //        string sessionCookie = context.Request.Headers["Cookie"];

            //        if ((sessionCookie != null) && (sessionCookie.IndexOf("ASP.NET_SessionId") >= 0))
            //        {

            //            string redirectTo = "~/Account/Logon";
            //            if (!string.IsNullOrEmpty(context.Request.RawUrl))
            //            {
            //                redirectTo = string.Format("~/Account/Logon?ReturnUrl={0}",
            //                    HttpUtility.UrlEncode(context.Request.RawUrl));
            //            }
            //            filterContext.Result = new RedirectResult(redirectTo);
            //        }
            //    }
            //}

            base.OnActionExecuting(filterContext);
        }
    }
}
