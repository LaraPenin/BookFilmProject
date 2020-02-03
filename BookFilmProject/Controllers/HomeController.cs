using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//Este es el CONTROLADOR del la vista principal que deriva a la Vista Libro y la Vista Película

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