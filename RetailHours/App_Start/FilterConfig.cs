using RetailHours.Models;
using System.Web;
using System.Web.Mvc;

namespace RetailHours
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new CookieCheck());
        }
    }
}
