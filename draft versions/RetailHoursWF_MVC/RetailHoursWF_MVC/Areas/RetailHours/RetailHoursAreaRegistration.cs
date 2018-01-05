using System.Web.Mvc;

namespace RetailHoursWF_MVC.Areas.RetailHours
{
    public class RetailHoursAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "RetailHours";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "RetailHours_default",
                "RetailHours/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}