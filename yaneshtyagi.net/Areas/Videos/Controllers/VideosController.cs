using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace yaneshtyagi.net.Areas.Videos.Controllers
{
    public class VideosController : Controller
    {
        //
        // GET: /Videos/Videos/
        public ActionResult Index()
        {
            return View("Videos");
        }
	}
}