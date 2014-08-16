using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace yaneshtyagi.net.Areas.Spirituality.Controllers
{
    public class LinageController : Controller
    {
        //
        // GET: /Spirituality/Linage/
        public ActionResult Index()
        {
            return View("LinageOfTirthOrder");
        }

        // GET: /Spirituality/Linage/SwamiParmanandTirth
        public ActionResult SwamiParmanandTirth()
        {
            return View("SwamiParmanandTirth");
        }

        // GET: /Spirituality/Linage/SwamiMukundTirth
        public ActionResult SwamiMukundTirth()
        {
            return View("SwamiMukundTirth");
        }

        // GET: /Spirituality/Linage/SwamiGangadharTirth
        public ActionResult SwamiGangadharTirth()
        {
            return View("SwamiGangadharTirth");
        }

        // GET: /Spirituality/Linage/SwamiNarayanTirth
        public ActionResult SwamiNarayanTirth()
        {
            return View("SwamiNarayanTirth");
        }

        // GET: /Spirituality/Linage/SwamiYoganandaMaharaj
        public ActionResult SwamiYoganandaMaharaj()
        {
            return View("SwamiYoganandaMaharaj");
        }

        // GET: /Spirituality/Linage/SwamiVishnuTirth
        public ActionResult SwamiVishnuTirth()
        {
            return View("SwamiVishnuTirth");
        }

        // GET: /Spirituality/Linage/SwamiShivomTirth
        public ActionResult SwamiShivomTirth()
        {
            return View("SwamiShivomTirth");
        }

        // GET: /Spirituality/Linage/SwamiGovindanandTirth
        public ActionResult SwamiGovindanandTirth()
        {
            Response.Redirect("Spirituality/SwamiGovindanandTirth");
            return View("SwamiGovindanandTirth");
        }

        // GET: /Spirituality/Linage/SwamiMrityunjayTirth
        public ActionResult SwamiMrityunjayTirth()
        {
            return View("SwamiMrityunjayTirth");
        }
    
    }
}