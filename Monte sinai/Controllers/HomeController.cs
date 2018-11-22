using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Monte_sinai.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.Message = "Esta es mi primera Aplicacion";
            ViewBag.suma = 2 + 2;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Location()
        {
            ViewBag.Message = "Our Location";

            return View();
        }
        public ActionResult inicio()
        {


            return View();

        }
        public ActionResult hom ()
        {


            return View();

        }
        public ActionResult rolles ()
        {


            return View();

        }
        public ActionResult services ()
        {


            return View();

        }
    }
}