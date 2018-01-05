using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RetailHoursMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}", // tried: url:"setHours" which worked locally
                defaults: new { controller = "tblRtlHours", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
