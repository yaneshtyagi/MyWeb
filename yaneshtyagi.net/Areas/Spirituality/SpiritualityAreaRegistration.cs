using System.Web.Mvc;

namespace yaneshtyagi.net.Areas.Spirituality
{
    public class SpiritualityAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Spirituality";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Spirituality_default",
                "Spirituality/{controller}/{action}/{id}",
                new { controller = "Spirituality", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}