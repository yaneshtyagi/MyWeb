using System.Web.Mvc;

namespace yaneshtyagi.net.Areas.Videos
{
    public class VideosAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Videos";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Videos_default",
                "Videos/{controller}/{action}/{id}",
                new { controller="Videos", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}