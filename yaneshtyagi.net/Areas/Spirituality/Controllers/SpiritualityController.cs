using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace yaneshtyagi.net.Areas.Spirituality.Controllers
{
    public class SpiritualityController : Controller
    {
        //
        // GET: /Spirituality/Home/
        public ActionResult Index()
        {
            return View("Spirituality");
        }

        // GET: /Spirituality/Home/
        public ActionResult LinageOfTirthOrder()
        {
            return View("LinageOfTirthOrder");
        }

    }
}