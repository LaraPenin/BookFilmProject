using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookFilmProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Principal()
        {
            return View();
        }
    }
}