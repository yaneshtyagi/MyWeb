using System.Web.Mvc;

namespace yaneshtyagi.net.Areas.Books
{
    public class BooksAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Books";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Books_default",
                "Books/{controller}/{action}/{id}",
                new { controller="Books", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}