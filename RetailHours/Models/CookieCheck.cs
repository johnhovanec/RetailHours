using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RetailHours.Models
{
    public class CookieCheck : ActionFilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            int intIsAuthorized = 0;
            // Check for cookie, redirect if not found
            if (filterContext.HttpContext.Request.Cookies["RetailHours"] != null)
            {
                // Get value of cookie
                var strAuth_Cookie = filterContext.HttpContext.Request.Cookies["RetailHours"]["Auth"];
                // Check for 'True' within cookie value
                intIsAuthorized = strAuth_Cookie.IndexOf("True");
            }
            // Redirect if the cookie wasn't found
            else
            {
                filterContext.Result = new RedirectResult("/GroupAuthentication/Home/UnAuthorized");
            }
            
            // If user is authorized intIsAuthorized will be > 0 and the application will load, otherwise redirect
            if (intIsAuthorized <= 0)
            {
                filterContext.Result = new RedirectResult("/GroupAuthentication/Home/UnAuthorized");
            }
        }
    }
}