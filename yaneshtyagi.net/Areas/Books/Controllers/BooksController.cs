﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace yaneshtyagi.net.Areas.Books.Controllers
{
    public class BooksController : Controller
    {
        //
        // GET: /Books/Books/
        public ActionResult Index()
        {
            return View("Books");
        }
	}
}